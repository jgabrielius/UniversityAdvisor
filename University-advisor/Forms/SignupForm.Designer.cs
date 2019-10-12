namespace University_advisor.Forms
{
    partial class SignupForm
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
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.universityBox = new System.Windows.Forms.ComboBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.universityLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(205, 140);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(180, 20);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(205, 176);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(180, 20);
            this.lastNameText.TabIndex = 3;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(205, 101);
            this.emailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(180, 20);
            this.emailText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(205, 297);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(180, 20);
            this.passwordText.TabIndex = 7;
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.Location = new System.Drawing.Point(205, 335);
            this.confirmPasswordText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.PasswordChar = '*';
            this.confirmPasswordText.Size = new System.Drawing.Size(180, 20);
            this.confirmPasswordText.TabIndex = 9;
            // 
            // universityBox
            // 
            this.universityBox.BackColor = System.Drawing.SystemColors.Window;
            this.universityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universityBox.DropDownWidth = 500;
            this.universityBox.FormattingEnabled = true;
            this.universityBox.IntegralHeight = false;
            this.universityBox.Location = new System.Drawing.Point(205, 213);
            this.universityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.universityBox.Name = "universityBox";
            this.universityBox.Size = new System.Drawing.Size(180, 21);
            this.universityBox.TabIndex = 12;
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(205, 254);
            this.statusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(180, 21);
            this.statusBox.TabIndex = 13;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(205, 61);
            this.usernameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(180, 20);
            this.usernameText.TabIndex = 16;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(99, 58);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 20);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "USERNAME: ";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(138, 98);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 20);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "EMAIL: ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.firstNameLabel.Location = new System.Drawing.Point(93, 136);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(114, 20);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "FIRST NAME: ";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastNameLabel.Location = new System.Drawing.Point(97, 173);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(107, 20);
            this.lastNameLabel.TabIndex = 20;
            this.lastNameLabel.Text = "LAST NAME: ";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // universityLabel
            // 
            this.universityLabel.AutoSize = true;
            this.universityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.universityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.universityLabel.Location = new System.Drawing.Point(93, 213);
            this.universityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.universityLabel.Name = "universityLabel";
            this.universityLabel.Size = new System.Drawing.Size(111, 20);
            this.universityLabel.TabIndex = 21;
            this.universityLabel.Text = "UNIVERSITY:";
            this.universityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLabel.Location = new System.Drawing.Point(120, 254);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(76, 20);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "STATUS:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(93, 297);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 20);
            this.passwordLabel.TabIndex = 23;
            this.passwordLabel.Text = "PASSWORD:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(20, 332);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(185, 20);
            this.confirmPasswordLabel.TabIndex = 24;
            this.confirmPasswordLabel.Text = "CONFIRM PASSWORD:";
            this.confirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(72, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "CREATE NEW ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.createAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.createAccountButton.Location = new System.Drawing.Point(205, 380);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(226, 46);
            this.createAccountButton.TabIndex = 26;
            this.createAccountButton.Text = "CREATE NEW ACCOUNT";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.backButton.Location = new System.Drawing.Point(9, 380);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(186, 46);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(445, 463);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.universityLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.universityBox);
            this.Controls.Add(this.confirmPasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignupForm";
            this.Text = "Create new account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox confirmPasswordText;
        private System.Windows.Forms.ComboBox universityBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label universityLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button backButton;
    }
}