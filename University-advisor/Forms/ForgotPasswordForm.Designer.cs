namespace University_advisor.Forms
{
    partial class ForgotPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "EMAIL: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "USERNAME: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(39, 99);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(238, 22);
            this.usernameText.TabIndex = 23;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(39, 170);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(238, 22);
            this.emailText.TabIndex = 22;
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.ResetPasswordButton.FlatAppearance.BorderSize = 0;
            this.ResetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPasswordButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.ResetPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.ResetPasswordButton.Location = new System.Drawing.Point(39, 216);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(238, 51);
            this.ResetPasswordButton.TabIndex = 26;
            this.ResetPasswordButton.Text = "RESET PASSWORD";
            this.ResetPasswordButton.UseVisualStyleBackColor = false;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(43)))), ((int)(((byte)(177)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Calibri", 15F);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.backButton.Location = new System.Drawing.Point(39, 276);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(238, 51);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "PASSWORD RESET";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(318, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.emailText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.Text = "Password reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button ResetPasswordButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
    }
}