using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using University_advisor.Tools;
using System.Diagnostics;
using University_advisor.Services;
using University_advisor.Models;
using Control = System.Windows.Forms.Control;
using RadioButton = System.Windows.Forms.RadioButton;
using Panel = System.Windows.Forms.Panel;

namespace University_advisor.Forms
{
    public partial class MainForm : Form
    {
        string currentUser;
        ArrayList statusList = new ArrayList() { "Student", "Graduate", "Lecturer" };
        ControlGMap map;
        int selectedCourse;
        int selectedUniversity;

        public MainForm(string username)
        {
            Debug.Write("loaded main");
            InitializeComponent();
            CenterToScreen();
            InstantiateGrid();
            currentUser = username;
            SetValues();
            tabsController.Appearance = TabAppearance.FlatButtons;
            tabsController.ItemSize = new Size(0, 1);
            tabsController.SizeMode = TabSizeMode.Fixed;
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(homeTab);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(homeTab);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(settingsTab);
            SetValues();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(aboutTab);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(logOutTab);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(homeTab);
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            new UserEditingService(currentUser).ChangePassword(currentPassword.Text, newPassword.Text, newPassword2.Text);
            ClearValues();
        }

        private void ChangeEmail_Click(object sender, EventArgs e)
        {
            new UserEditingService(currentUser).ChangeEmail(currentEmail.Text, newEmail.Text, newEmail2.Text);
            ClearValues();
        }

        private void ChangeUniversity_Click(object sender, EventArgs e)
        {
            new UserEditingService(currentUser).ChangeUniversity(universityBox.SelectedItem.ToString());
            ClearValues();
        }

        private void ChangeStatus_Click(object sender, EventArgs e)
        {
            new UserEditingService(currentUser).ChangeStatus(statusBox.SelectedItem.ToString());
            ClearValues();
        }

        private void SetValues()
        {
            UserEditingService service = new UserEditingService(currentUser);
            universityBox.DataSource = service.GetAllUniversities();
            universityBox.SelectedItem = service.GetCurrentUniversity();
            statusBox.DataSource = statusList;
            statusBox.SelectedItem = service.GetCurrentStatus();
        }

        private void ClearValues()
        {
            currentPassword.Clear();
            newPassword.Clear();
            newPassword2.Clear();
            currentEmail.Clear();
            newEmail.Clear();
            newEmail2.Clear();
        }

        private void InstantiateGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            ArrayList universities = SqlDriver.Fetch("SELECT universityId,name FROM universities");
            foreach (Dictionary<string, object> row in universities)
            {
                table.Rows.Add(row["universityId"], row["name"]);
            }
            universitiesGrid.DataSource = table;
        }
        private void InstantiateProgramsGrid(int universityId)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Group", typeof(string));
            table.Columns.Add("Direction", typeof(string));
            table.Columns.Add("Program", typeof(string));
            table.Columns.Add("Presentation of content", typeof(string));
            table.Columns.Add("Clarity of expectations", typeof(string));
            table.Columns.Add("Clear feedback on performance", typeof(string));
            table.Columns.Add("Encouragment of participation/discussion", typeof(string));
            table.Columns.Add("Overall teaching effectiveness", typeof(string));
            table.Columns.Add("How satisfied were you with this course", typeof(string));
            ArrayList programmes = SqlDriver.Fetch($"SELECT studyProgramId,[group],direction,program,city," +
                $"avg(presentation) as presentation,avg(clarity) as clarity,avg(feedback) as feedback, avg(encouragement) as encouragement,avg(effectiveness) as effectiveness,avg(satisfaction) as satisfaction " +
                $"FROM studyProgrammes left join courseReviews on studyProgramId=courseId" +
                $" WHERE universityId = {universityId} group by studyProgramId,[group], direction, program, city");
            foreach (Dictionary<string, object> row in programmes)
            {
                table.Rows.Add(row["studyProgramId"],row["group"], row["direction"], row["program"], row["presentation"], row["clarity"], row["feedback"], row["encouragement"], row["effectiveness"], row["satisfaction"]);
            }
            programmesGrid.DataSource = table;
        }

        private void UniversitiesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            int selectedId = (int)dgv.CurrentRow.Cells["Id"].Value;
            string selectedName = dgv.CurrentRow.Cells["Name"].Value.ToString();
            universityName.Text = selectedName;
            InstantiateProgramsGrid(selectedId);
            selectedUniversity = selectedId;
            tabsController.SelectTab(universityTab);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(50);
            comboBox1.Items.Add(100);
            comboBox1.Items.Add(250);
            comboBox1.Items.Add(500);
            comboBox1.Items.Add(1000);
            comboBox1.Items.Add(2000);

            searchButton.TabStop = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.FlatAppearance.BorderSize = 0;

            tabsController.SelectTab(findSchoolsTab);
        }
        private void gMap_Load(object sender, EventArgs e)
        {
            map = new ControlGMap(gMap);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            map.UpdateMap(comboBox1.Text, textBox1.Text);
        }

        private void ProgrammesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            int selectedId = (int)dgv.CurrentRow.Cells["Id"].Value;
            selectedCourse = selectedId;
            tabsController.SelectTab(courseReview);
        }

        private void ReviewSubmit_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(universityReview);
        }

        private void SubmitCourseReview_Click(object sender, EventArgs e)
        {
            List<Panel> panels = new List<Panel> { presentation, clarity, feedback, encouragement, effectiveness, satisfaction };
            Dictionary<string, string> result = ExtractReviews(panels);
            string insert = "INSERT INTO coursereviews (";
            string values = "VALUES (";
            foreach(var item in result)
            {
                insert += item.Key+",";
                values += item.Value + ",";
            }
            insert += "courseId)";
            values += selectedCourse+")";
            SqlDriver.Execute(insert + values);
            tabsController.SelectTab(courseReview);
        }

        private void SubmitUniversityReview_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string,string> ExtractReviews(List<Panel> panels)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach(Panel p in panels)
            {
                foreach(Control c in p.Controls)
                {
                    if (c.GetType() == typeof(RadioButton))
                    {
                        RadioButton btn = (RadioButton)c;
                        if (btn.Checked == true)
                        {
                            result.Add(p.Name,btn.Text);
                        }
                    }
                }
            }
            return result;
        }
    }
}
