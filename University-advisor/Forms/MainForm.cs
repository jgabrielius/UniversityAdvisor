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

namespace University_advisor.Forms
{
    public partial class MainForm : Form
    {
        string currentUser;
        ArrayList statusList = new ArrayList() { "Student", "Graduate", "Lecturer" };
        ControlGMap map;

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

        private void UniversitiesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            int selectedId = (int)dgv.CurrentRow.Cells["Id"].Value;
            string selectedName = dgv.CurrentRow.Cells["Name"].Value.ToString();
            universityName.Text = selectedName;
            tabsController.SelectTab(universityTab);

        }

        private void ReviewSubmit_Click(object sender, EventArgs e)
        {
            string review = universityReview.Text;
            int rating = 0;
            if (veryBadButton.Checked)
            {
                rating = 1;
            }
            else if (badButton.Checked)
            {
                rating = 2;
            }
            else if (goodButton.Checked)
            {
                rating = 3;
            }
            else if (veryGoodButton.Checked)
            {
                rating = 4;
            }

            if (review.Length == 0 || rating == 0)
            {
                MessageBox.Show("Your review or rating is empty", "Error");
            }
            else
            {
                MessageBox.Show("Thank you for submitting your review", "Review submitted");
                universityReview.Clear();
                veryBadButton.Checked = false;
                badButton.Checked = false;
                goodButton.Checked = false;
                veryGoodButton.Checked = false;
            }
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
    }
}
