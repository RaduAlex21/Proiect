namespace Utility
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.EmailBox = new CustomControls.RJControls.TextBoxDesign();
            this.CodeBox = new CustomControls.RJControls.TextBoxDesign();
            this.VerifyCode = new CustomControls.RJControls.ButtonDesign();
            this.emailcode = new CustomControls.RJControls.ButtonDesign();
            this.ForgotPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePW = new CustomControls.RJControls.ButtonDesign();
            this.newpassword = new CustomControls.RJControls.TextBoxDesign();
            this.email = new CustomControls.RJControls.TextBoxDesign();
            this.toggleBtnDesign1 = new CustomControls.RJControls.ToggleBtnDesign();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.EmailBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.EmailBox.BorderRadius = 15;
            this.EmailBox.BorderSize = 1;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailBox.Location = new System.Drawing.Point(74, 136);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Multiline = false;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EmailBox.PasswordChar = false;
            this.EmailBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.EmailBox.PlaceholderText = "Your Email";
            this.EmailBox.Size = new System.Drawing.Size(250, 31);
            this.EmailBox.TabIndex = 0;
            this.EmailBox.Texts = "";
            this.EmailBox.UnderlinedStyle = false;
            // 
            // CodeBox
            // 
            this.CodeBox.BackColor = System.Drawing.SystemColors.Window;
            this.CodeBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.CodeBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.CodeBox.BorderRadius = 15;
            this.CodeBox.BorderSize = 1;
            this.CodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodeBox.Location = new System.Drawing.Point(74, 262);
            this.CodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeBox.Multiline = false;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CodeBox.PasswordChar = false;
            this.CodeBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CodeBox.PlaceholderText = "Email Code";
            this.CodeBox.Size = new System.Drawing.Size(250, 31);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Texts = "";
            this.CodeBox.UnderlinedStyle = false;
            // 
            // VerifyCode
            // 
            this.VerifyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.VerifyCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.VerifyCode.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.VerifyCode.BorderRadius = 20;
            this.VerifyCode.BorderSize = 0;
            this.VerifyCode.FlatAppearance.BorderSize = 0;
            this.VerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyCode.ForeColor = System.Drawing.Color.Black;
            this.VerifyCode.Location = new System.Drawing.Point(174, 300);
            this.VerifyCode.Name = "VerifyCode";
            this.VerifyCode.Size = new System.Drawing.Size(150, 40);
            this.VerifyCode.TabIndex = 2;
            this.VerifyCode.Text = "Verify Code";
            this.VerifyCode.TextColor = System.Drawing.Color.Black;
            this.VerifyCode.UseVisualStyleBackColor = false;
            this.VerifyCode.Click += new System.EventHandler(this.VerifyCode_Click);
            // 
            // emailcode
            // 
            this.emailcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.emailcode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.emailcode.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.emailcode.BorderRadius = 20;
            this.emailcode.BorderSize = 0;
            this.emailcode.FlatAppearance.BorderSize = 0;
            this.emailcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailcode.ForeColor = System.Drawing.Color.Black;
            this.emailcode.Location = new System.Drawing.Point(174, 174);
            this.emailcode.Name = "emailcode";
            this.emailcode.Size = new System.Drawing.Size(150, 40);
            this.emailcode.TabIndex = 3;
            this.emailcode.Text = "Send Code";
            this.emailcode.TextColor = System.Drawing.Color.Black;
            this.emailcode.UseVisualStyleBackColor = false;
            this.emailcode.Click += new System.EventHandler(this.emailcode_Click);
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPassword.Location = new System.Drawing.Point(53, 36);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(293, 52);
            this.ForgotPassword.TabIndex = 23;
            this.ForgotPassword.Text = "ForgotPassword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 52);
            this.label1.TabIndex = 28;
            this.label1.Text = "Change Password";
            // 
            // ChangePW
            // 
            this.ChangePW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.ChangePW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.ChangePW.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ChangePW.BorderRadius = 20;
            this.ChangePW.BorderSize = 0;
            this.ChangePW.FlatAppearance.BorderSize = 0;
            this.ChangePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePW.ForeColor = System.Drawing.Color.Black;
            this.ChangePW.Location = new System.Drawing.Point(174, 233);
            this.ChangePW.Name = "ChangePW";
            this.ChangePW.Size = new System.Drawing.Size(150, 40);
            this.ChangePW.TabIndex = 26;
            this.ChangePW.Text = "New Password";
            this.ChangePW.TextColor = System.Drawing.Color.Black;
            this.ChangePW.UseVisualStyleBackColor = false;
            this.ChangePW.Click += new System.EventHandler(this.ChangePW_Click);
            // 
            // newpassword
            // 
            this.newpassword.BackColor = System.Drawing.SystemColors.Window;
            this.newpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.newpassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.newpassword.BorderRadius = 15;
            this.newpassword.BorderSize = 1;
            this.newpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newpassword.Location = new System.Drawing.Point(74, 183);
            this.newpassword.Margin = new System.Windows.Forms.Padding(4);
            this.newpassword.Multiline = false;
            this.newpassword.Name = "newpassword";
            this.newpassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.newpassword.PasswordChar = true;
            this.newpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.newpassword.PlaceholderText = "New Password";
            this.newpassword.Size = new System.Drawing.Size(250, 31);
            this.newpassword.TabIndex = 25;
            this.newpassword.Texts = "";
            this.newpassword.UnderlinedStyle = false;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Window;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.email.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.email.BorderRadius = 15;
            this.email.BorderSize = 1;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.Location = new System.Drawing.Point(74, 121);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(250, 31);
            this.email.TabIndex = 24;
            this.email.Texts = "";
            this.email.UnderlinedStyle = false;
            // 
            // toggleBtnDesign1
            // 
            this.toggleBtnDesign1.AutoSize = true;
            this.toggleBtnDesign1.Location = new System.Drawing.Point(74, 233);
            this.toggleBtnDesign1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleBtnDesign1.Name = "toggleBtnDesign1";
            this.toggleBtnDesign1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleBtnDesign1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleBtnDesign1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleBtnDesign1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleBtnDesign1.Size = new System.Drawing.Size(45, 22);
            this.toggleBtnDesign1.TabIndex = 29;
            this.toggleBtnDesign1.UseVisualStyleBackColor = true;
            this.toggleBtnDesign1.CheckedChanged += new System.EventHandler(this.toggleBtnDesign1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(356, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toggleBtnDesign1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePW);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ForgotPassword);
            this.Controls.Add(this.emailcode);
            this.Controls.Add(this.VerifyCode);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.EmailBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.TextBoxDesign EmailBox;
        private CustomControls.RJControls.TextBoxDesign CodeBox;
        private CustomControls.RJControls.ButtonDesign VerifyCode;
        private CustomControls.RJControls.ButtonDesign emailcode;
        private Label ForgotPassword;
        private Label label1;
        private CustomControls.RJControls.ButtonDesign ChangePW;
        private CustomControls.RJControls.TextBoxDesign newpassword;
        private CustomControls.RJControls.TextBoxDesign email;
        private CustomControls.RJControls.ToggleBtnDesign toggleBtnDesign1;
        private Button button1;
    }
}