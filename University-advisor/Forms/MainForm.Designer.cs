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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.logOutTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.logOutTab.SuspendLayout();
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
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(152, 80);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // logoButton
            // 
            this.logoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.logoButton.FlatAppearance.BorderSize = 0;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.logoButton.Location = new System.Drawing.Point(1, 0);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(272, 80);
            this.logoButton.TabIndex = 3;
            this.logoButton.Text = "University advisor";
            this.logoButton.UseVisualStyleBackColor = false;
            this.logoButton.Click += new System.EventHandler(this.logoButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.settingsButton.Location = new System.Drawing.Point(425, 1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(152, 80);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.logoutButton.Location = new System.Drawing.Point(729, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(152, 80);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.homeButton.Location = new System.Drawing.Point(273, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(152, 80);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(887, 347);
            this.homeTab.TabIndex = 2;
            this.homeTab.Text = "homeTab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(300, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME TAB";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Controls.Add(this.logOutTab);
            this.tabControl1.Location = new System.Drawing.Point(-9, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.settingsTab.Controls.Add(this.label2);
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(887, 347);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "settingsTab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(300, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "SETTINGS TAB";
            // 
            // aboutTab
            // 
            this.aboutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.aboutTab.Controls.Add(this.label3);
            this.aboutTab.Location = new System.Drawing.Point(4, 25);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(887, 347);
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
            this.logOutTab.Name = "logOutTab";
            this.logOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.logOutTab.Size = new System.Drawing.Size(887, 347);
            this.logOutTab.TabIndex = 5;
            this.logOutTab.Text = "logOutTab";
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
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yesButton.FlatAppearance.BorderSize = 0;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.yesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.yesButton.Location = new System.Drawing.Point(237, 125);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(193, 50);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noButton.FlatAppearance.BorderSize = 0;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.noButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.noButton.Location = new System.Drawing.Point(436, 125);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(193, 50);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(881, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.logOutTab.ResumeLayout(false);
            this.logOutTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.TabPage logOutTab;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label4;
    }
}