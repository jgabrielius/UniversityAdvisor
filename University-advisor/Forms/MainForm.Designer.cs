namespace University_advisor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.logoButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.universitiesGrid = new System.Windows.Forms.DataGridView();
            this.tabsController = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.ChangeStatus = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.universityBox = new System.Windows.Forms.ComboBox();
            this.ChangeUniversity = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.newEmail2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangeEmail = new System.Windows.Forms.Button();
            this.currentEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.logOutTab = new System.Windows.Forms.TabPage();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.universityTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.universityReview = new System.Windows.Forms.TextBox();
            this.universityName = new System.Windows.Forms.Label();
            this.veryBadButton = new System.Windows.Forms.RadioButton();
            this.badButton = new System.Windows.Forms.RadioButton();
            this.goodButton = new System.Windows.Forms.RadioButton();
            this.veryGoodButton = new System.Windows.Forms.RadioButton();
            this.reviewSubmit = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGrid)).BeginInit();
            this.tabsController.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.logOutTab.SuspendLayout();
            this.universityTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.aboutButton);
            this.menuPanel.Controls.Add(this.logoButton);
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(881, 80);
            this.menuPanel.TabIndex = 0;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.aboutButton.Location = new System.Drawing.Point(577, 0);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(152, 80);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // logoButton
            // 
            this.logoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.logoButton.FlatAppearance.BorderSize = 0;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.logoButton.Location = new System.Drawing.Point(1, 0);
            this.logoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(272, 80);
            this.logoButton.TabIndex = 3;
            this.logoButton.Text = "University advisor";
            this.logoButton.UseVisualStyleBackColor = false;
            this.logoButton.Click += new System.EventHandler(this.LogoButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.settingsButton.Location = new System.Drawing.Point(425, 1);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(152, 80);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.logoutButton.Location = new System.Drawing.Point(729, 0);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(152, 80);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.homeButton.Location = new System.Drawing.Point(273, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(152, 80);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.homeTab.Controls.Add(this.universitiesGrid);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeTab.Size = new System.Drawing.Size(888, 433);
            this.homeTab.TabIndex = 2;
            this.homeTab.Text = "homeTab";
            // 
            // universitiesGrid
            // 
            this.universitiesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.universitiesGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.universitiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universitiesGrid.Location = new System.Drawing.Point(20, 17);
            this.universitiesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universitiesGrid.Name = "universitiesGrid";
            this.universitiesGrid.ReadOnly = true;
            this.universitiesGrid.Size = new System.Drawing.Size(849, 409);
            this.universitiesGrid.TabIndex = 0;
            this.universitiesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UniversitiesGrid_CellClick);
            // 
            // tabsController
            // 
            this.tabsController.Controls.Add(this.homeTab);
            this.tabsController.Controls.Add(this.settingsTab);
            this.tabsController.Controls.Add(this.aboutTab);
            this.tabsController.Controls.Add(this.logOutTab);
            this.tabsController.Controls.Add(this.universityTab);
            this.tabsController.Location = new System.Drawing.Point(-9, 70);
            this.tabsController.Margin = new System.Windows.Forms.Padding(0);
            this.tabsController.Name = "tabsController";
            this.tabsController.SelectedIndex = 0;
            this.tabsController.Size = new System.Drawing.Size(896, 462);
            this.tabsController.TabIndex = 1;
            // 
            // settingsTab
            // 
            this.settingsTab.AutoScroll = true;
            this.settingsTab.AutoScrollMargin = new System.Drawing.Size(10, 50);
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.settingsTab.Controls.Add(this.statusBox);
            this.settingsTab.Controls.Add(this.ChangeStatus);
            this.settingsTab.Controls.Add(this.label14);
            this.settingsTab.Controls.Add(this.label15);
            this.settingsTab.Controls.Add(this.universityBox);
            this.settingsTab.Controls.Add(this.ChangeUniversity);
            this.settingsTab.Controls.Add(this.label12);
            this.settingsTab.Controls.Add(this.label13);
            this.settingsTab.Controls.Add(this.newEmail2);
            this.settingsTab.Controls.Add(this.label8);
            this.settingsTab.Controls.Add(this.newEmail);
            this.settingsTab.Controls.Add(this.label9);
            this.settingsTab.Controls.Add(this.ChangeEmail);
            this.settingsTab.Controls.Add(this.currentEmail);
            this.settingsTab.Controls.Add(this.label10);
            this.settingsTab.Controls.Add(this.label11);
            this.settingsTab.Controls.Add(this.newPassword2);
            this.settingsTab.Controls.Add(this.label7);
            this.settingsTab.Controls.Add(this.newPassword);
            this.settingsTab.Controls.Add(this.label5);
            this.settingsTab.Controls.Add(this.ChangePassword);
            this.settingsTab.Controls.Add(this.currentPassword);
            this.settingsTab.Controls.Add(this.label6);
            this.settingsTab.Controls.Add(this.label2);
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTab.Size = new System.Drawing.Size(888, 433);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "settingsTab";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(308, 754);
            this.statusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(219, 24);
            this.statusBox.TabIndex = 26;
            // 
            // ChangeStatus
            // 
            this.ChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.ChangeStatus.FlatAppearance.BorderSize = 0;
            this.ChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeStatus.Font = new System.Drawing.Font("Calibri", 15F);
            this.ChangeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.ChangeStatus.Location = new System.Drawing.Point(565, 738);
            this.ChangeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeStatus.Name = "ChangeStatus";
            this.ChangeStatus.Size = new System.Drawing.Size(272, 50);
            this.ChangeStatus.TabIndex = 25;
            this.ChangeStatus.Text = "Change Status";
            this.ChangeStatus.UseVisualStyleBackColor = false;
            this.ChangeStatus.Click += new System.EventHandler(this.ChangeStatus_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(117, 754);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "SELECT STATUS:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(205, 679);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 58);
            this.label15.TabIndex = 23;
            this.label15.Text = "CHANGE\rSTATUS:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // universityBox
            // 
            this.universityBox.FormattingEnabled = true;
            this.universityBox.Location = new System.Drawing.Point(308, 582);
            this.universityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.universityBox.Name = "universityBox";
            this.universityBox.Size = new System.Drawing.Size(219, 24);
            this.universityBox.TabIndex = 22;
            // 
            // ChangeUniversity
            // 
            this.ChangeUniversity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.ChangeUniversity.FlatAppearance.BorderSize = 0;
            this.ChangeUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUniversity.Font = new System.Drawing.Font("Calibri", 15F);
            this.ChangeUniversity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.ChangeUniversity.Location = new System.Drawing.Point(565, 567);
            this.ChangeUniversity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeUniversity.Name = "ChangeUniversity";
            this.ChangeUniversity.Size = new System.Drawing.Size(272, 50);
            this.ChangeUniversity.TabIndex = 21;
            this.ChangeUniversity.Text = "Change University";
            this.ChangeUniversity.UseVisualStyleBackColor = false;
            this.ChangeUniversity.Click += new System.EventHandler(this.ChangeUniversity_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(83, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "SELECT UNIVERSITY:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(205, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 58);
            this.label13.TabIndex = 18;
            this.label13.Text = "CHANGE\rUNIVERSITY:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newEmail2
            // 
            this.newEmail2.Location = new System.Drawing.Point(308, 441);
            this.newEmail2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEmail2.Name = "newEmail2";
            this.newEmail2.Size = new System.Drawing.Size(219, 22);
            this.newEmail2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(75, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONFIRM NEW EMAIL:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newEmail
            // 
            this.newEmail.Location = new System.Drawing.Point(308, 398);
            this.newEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(219, 22);
            this.newEmail.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(172, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "NEW EMAIL:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeEmail
            // 
            this.ChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.ChangeEmail.FlatAppearance.BorderSize = 0;
            this.ChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeEmail.Font = new System.Drawing.Font("Calibri", 15F);
            this.ChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.ChangeEmail.Location = new System.Drawing.Point(565, 378);
            this.ChangeEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeEmail.Name = "ChangeEmail";
            this.ChangeEmail.Size = new System.Drawing.Size(272, 50);
            this.ChangeEmail.TabIndex = 13;
            this.ChangeEmail.Text = "Change Email";
            this.ChangeEmail.UseVisualStyleBackColor = false;
            this.ChangeEmail.Click += new System.EventHandler(this.ChangeEmail_Click);
            // 
            // currentEmail
            // 
            this.currentEmail.Location = new System.Drawing.Point(308, 353);
            this.currentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentEmail.Name = "currentEmail";
            this.currentEmail.Size = new System.Drawing.Size(219, 22);
            this.currentEmail.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(124, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "CURRENT EMAIL:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(205, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 58);
            this.label11.TabIndex = 10;
            this.label11.Text = "CHANGE\r\nEMAIL:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPassword2
            // 
            this.newPassword2.Location = new System.Drawing.Point(308, 181);
            this.newPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.PasswordChar = '*';
            this.newPassword2.Size = new System.Drawing.Size(219, 22);
            this.newPassword2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(17, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "CONFIRM NEW PASSWORD:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(308, 137);
            this.newPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(219, 22);
            this.newPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(115, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "NEW PASSWORD:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Font = new System.Drawing.Font("Calibri", 15F);
            this.ChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.ChangePassword.Location = new System.Drawing.Point(565, 118);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(272, 50);
            this.ChangePassword.TabIndex = 5;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // currentPassword
            // 
            this.currentPassword.Location = new System.Drawing.Point(308, 94);
            this.currentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.PasswordChar = '*';
            this.currentPassword.Size = new System.Drawing.Size(219, 22);
            this.currentPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(67, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "CURRENT PASSWORD:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(205, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHANGE\r\nPASSWORD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutTab
            // 
            this.aboutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.aboutTab.Controls.Add(this.label3);
            this.aboutTab.Location = new System.Drawing.Point(4, 25);
            this.aboutTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aboutTab.Size = new System.Drawing.Size(888, 433);
            this.aboutTab.TabIndex = 4;
            this.aboutTab.Text = "aboutTab";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(300, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "ABOUT TAB";
            // 
            // logOutTab
            // 
            this.logOutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.logOutTab.Controls.Add(this.noButton);
            this.logOutTab.Controls.Add(this.yesButton);
            this.logOutTab.Controls.Add(this.label4);
            this.logOutTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.logOutTab.Location = new System.Drawing.Point(4, 25);
            this.logOutTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutTab.Name = "logOutTab";
            this.logOutTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutTab.Size = new System.Drawing.Size(888, 433);
            this.logOutTab.TabIndex = 5;
            this.logOutTab.Text = "logOutTab";
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noButton.FlatAppearance.BorderSize = 0;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.noButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.noButton.Location = new System.Drawing.Point(436, 126);
            this.noButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(193, 50);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.yesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.yesButton.Location = new System.Drawing.Point(237, 126);
            this.yesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(193, 50);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(283, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 54);
            this.label4.TabIndex = 1;
            this.label4.Text = "Are you sure?";
            // 
            // universityTab
            // 
            this.universityTab.AutoScroll = true;
            this.universityTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.universityTab.Controls.Add(this.reviewSubmit);
            this.universityTab.Controls.Add(this.veryGoodButton);
            this.universityTab.Controls.Add(this.goodButton);
            this.universityTab.Controls.Add(this.badButton);
            this.universityTab.Controls.Add(this.veryBadButton);
            this.universityTab.Controls.Add(this.label1);
            this.universityTab.Controls.Add(this.universityReview);
            this.universityTab.Controls.Add(this.universityName);
            this.universityTab.Location = new System.Drawing.Point(4, 25);
            this.universityTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universityTab.Name = "universityTab";
            this.universityTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universityTab.Size = new System.Drawing.Size(888, 433);
            this.universityTab.TabIndex = 6;
            this.universityTab.Text = "universityTab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(348, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOUR REVIEW:";
            // 
            // universityReview
            // 
            this.universityReview.Location = new System.Drawing.Point(18, 202);
            this.universityReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universityReview.Multiline = true;
            this.universityReview.Name = "universityReview";
            this.universityReview.Size = new System.Drawing.Size(855, 171);
            this.universityReview.TabIndex = 1;
            // 
            // universityName
            // 
            this.universityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.universityName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.universityName.Location = new System.Drawing.Point(18, 0);
            this.universityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.universityName.Name = "universityName";
            this.universityName.Size = new System.Drawing.Size(855, 121);
            this.universityName.TabIndex = 0;
            this.universityName.Text = "UNIVERSITY:";
            this.universityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // veryBadButton
            // 
            this.veryBadButton.AutoSize = true;
            this.veryBadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.veryBadButton.ForeColor = System.Drawing.Color.Red;
            this.veryBadButton.Location = new System.Drawing.Point(26, 124);
            this.veryBadButton.Name = "veryBadButton";
            this.veryBadButton.Size = new System.Drawing.Size(132, 29);
            this.veryBadButton.TabIndex = 4;
            this.veryBadButton.TabStop = true;
            this.veryBadButton.Text = "VERY BAD";
            this.veryBadButton.UseVisualStyleBackColor = true;
            // 
            // badButton
            // 
            this.badButton.AutoSize = true;
            this.badButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.badButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.badButton.Location = new System.Drawing.Point(278, 124);
            this.badButton.Name = "badButton";
            this.badButton.Size = new System.Drawing.Size(74, 29);
            this.badButton.TabIndex = 5;
            this.badButton.TabStop = true;
            this.badButton.Text = "BAD";
            this.badButton.UseVisualStyleBackColor = true;
            // 
            // goodButton
            // 
            this.goodButton.AutoSize = true;
            this.goodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.goodButton.Location = new System.Drawing.Point(475, 124);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(94, 29);
            this.goodButton.TabIndex = 6;
            this.goodButton.TabStop = true;
            this.goodButton.Text = "GOOD";
            this.goodButton.UseVisualStyleBackColor = true;
            // 
            // veryGoodButton
            // 
            this.veryGoodButton.AutoSize = true;
            this.veryGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.veryGoodButton.ForeColor = System.Drawing.Color.Lime;
            this.veryGoodButton.Location = new System.Drawing.Point(698, 124);
            this.veryGoodButton.Name = "veryGoodButton";
            this.veryGoodButton.Size = new System.Drawing.Size(152, 29);
            this.veryGoodButton.TabIndex = 7;
            this.veryGoodButton.TabStop = true;
            this.veryGoodButton.Text = "VERY GOOD";
            this.veryGoodButton.UseVisualStyleBackColor = true;
            // 
            // reviewSubmit
            // 
            this.reviewSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.reviewSubmit.FlatAppearance.BorderSize = 0;
            this.reviewSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewSubmit.Font = new System.Drawing.Font("Calibri", 15F);
            this.reviewSubmit.ForeColor = System.Drawing.Color.White;
            this.reviewSubmit.Location = new System.Drawing.Point(318, 379);
            this.reviewSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reviewSubmit.Name = "reviewSubmit";
            this.reviewSubmit.Size = new System.Drawing.Size(264, 41);
            this.reviewSubmit.TabIndex = 8;
            this.reviewSubmit.Text = "SUBMIT";
            this.reviewSubmit.UseVisualStyleBackColor = false;
            this.reviewSubmit.Click += new System.EventHandler(this.ReviewSubmit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(881, 526);
            this.Controls.Add(this.tabsController);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "University Advisor";
            this.menuPanel.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGrid)).EndInit();
            this.tabsController.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.logOutTab.ResumeLayout(false);
            this.logOutTab.PerformLayout();
            this.universityTab.ResumeLayout(false);
            this.universityTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabControl tabsController;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.TabPage logOutTab;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeUniversity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox newEmail2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ChangeEmail;
        private System.Windows.Forms.TextBox currentEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newPassword2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Button ChangeStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox universityBox;
        private System.Windows.Forms.DataGridView universitiesGrid;
        private System.Windows.Forms.TabPage universityTab;
        private System.Windows.Forms.Label universityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox universityReview;
        private System.Windows.Forms.RadioButton veryBadButton;
        private System.Windows.Forms.RadioButton veryGoodButton;
        private System.Windows.Forms.RadioButton goodButton;
        private System.Windows.Forms.RadioButton badButton;
        private System.Windows.Forms.Button reviewSubmit;
    }
}