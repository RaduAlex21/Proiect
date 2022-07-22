namespace UserForms
{
    partial class Help
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
            this.emailmesajbox = new System.Windows.Forms.TextBox();
            this.SendMailBTN = new CustomControls.RJControls.ButtonDesign();
            this.emailcombobox = new LicentaFacultate.Controls.ComboBoxDesign();
            this.emailtextbox = new CustomControls.RJControls.TextBoxDesign();
            this.SuspendLayout();
            // 
            // emailmesajbox
            // 
            this.emailmesajbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailmesajbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailmesajbox.Location = new System.Drawing.Point(12, 196);
            this.emailmesajbox.Multiline = true;
            this.emailmesajbox.Name = "emailmesajbox";
            this.emailmesajbox.Size = new System.Drawing.Size(779, 292);
            this.emailmesajbox.TabIndex = 71;
            this.emailmesajbox.Text = "Message";
            // 
            // SendMailBTN
            // 
            this.SendMailBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.SendMailBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.SendMailBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SendMailBTN.BorderRadius = 15;
            this.SendMailBTN.BorderSize = 0;
            this.SendMailBTN.FlatAppearance.BorderSize = 0;
            this.SendMailBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMailBTN.ForeColor = System.Drawing.Color.Black;
            this.SendMailBTN.Location = new System.Drawing.Point(641, 82);
            this.SendMailBTN.Name = "SendMailBTN";
            this.SendMailBTN.Size = new System.Drawing.Size(150, 40);
            this.SendMailBTN.TabIndex = 72;
            this.SendMailBTN.Text = "Send";
            this.SendMailBTN.TextColor = System.Drawing.Color.Black;
            this.SendMailBTN.UseVisualStyleBackColor = false;
            this.SendMailBTN.Click += new System.EventHandler(this.SendMailBTN_Click);
            // 
            // emailcombobox
            // 
            this.emailcombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emailcombobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.emailcombobox.BorderSize = 1;
            this.emailcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.emailcombobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailcombobox.ForeColor = System.Drawing.Color.DimGray;
            this.emailcombobox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.emailcombobox.Items.AddRange(new object[] {
            "rcroitoru16@gmail.com",
            "rcroitoru17@gmail.com"});
            this.emailcombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.emailcombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.emailcombobox.Location = new System.Drawing.Point(12, 50);
            this.emailcombobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.emailcombobox.Name = "emailcombobox";
            this.emailcombobox.Padding = new System.Windows.Forms.Padding(1);
            this.emailcombobox.Size = new System.Drawing.Size(604, 30);
            this.emailcombobox.TabIndex = 73;
            this.emailcombobox.Texts = "";
            // 
            // emailtextbox
            // 
            this.emailtextbox.BackColor = System.Drawing.SystemColors.Window;
            this.emailtextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.emailtextbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.emailtextbox.BorderRadius = 15;
            this.emailtextbox.BorderSize = 1;
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailtextbox.Location = new System.Drawing.Point(13, 111);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailtextbox.Multiline = false;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailtextbox.PasswordChar = false;
            this.emailtextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailtextbox.PlaceholderText = "Subiect";
            this.emailtextbox.Size = new System.Drawing.Size(603, 31);
            this.emailtextbox.TabIndex = 74;
            this.emailtextbox.Texts = "";
            this.emailtextbox.UnderlinedStyle = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.emailcombobox);
            this.Controls.Add(this.SendMailBTN);
            this.Controls.Add(this.emailmesajbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailmesajbox;
        private CustomControls.RJControls.ButtonDesign SendMailBTN;
        private LicentaFacultate.Controls.ComboBoxDesign emailcombobox;
        private CustomControls.RJControls.TextBoxDesign emailtextbox;
    }
}