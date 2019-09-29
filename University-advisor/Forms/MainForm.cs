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
using University_advisor.Tools;
using System.Diagnostics;
using University_advisor.Services;

namespace University_advisor.Forms
{
    public partial class MainForm : Form
    {
        string currentUser;
        ArrayList statusList = new ArrayList() { "Student", "Graduate", "Lecturer" };

        public MainForm(string username)
        {
            Debug.Write("loaded main");
            InitializeComponent();
            CenterToScreen();
            SetValues();
            InstantiateGrid();
            currentUser = username;
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
            tabsController.SelectTab(settingsTab);
            tabsController.SelectTab(settingsTab);
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
            var universityResult = SqlDriver.Fetch("SELECT name FROM universities");
            if (universityResult.Count != 0)
            {
                var universityList = new List<string>();
                foreach (Dictionary<string, object> row in universityResult)
                {
                    universityList.Add(row["name"].ToString());
                }
                universityBox.DataSource = universityList;
                statusBox.DataSource = statusList;
            }
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
    }
}
