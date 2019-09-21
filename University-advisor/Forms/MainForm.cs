using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_advisor.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void logoButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(settingsTab);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(aboutTab);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(logOutTab);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }
    }
}
