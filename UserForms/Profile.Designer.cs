namespace ConcursDrx.UserForms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Register = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelrent = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(366, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 55);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.labelrent);
            this.panel4.Location = new System.Drawing.Point(339, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 80);
            this.panel4.TabIndex = 10;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register.Location = new System.Drawing.Point(280, 60);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(177, 52);
            this.Register.TabIndex = 23;
            this.Register.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(488, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "label";
            // 
            // labelrent
            // 
            this.labelrent.AutoSize = true;
            this.labelrent.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrent.Location = new System.Drawing.Point(130, 21);
            this.labelrent.Name = "labelrent";
            this.labelrent.Size = new System.Drawing.Size(76, 38);
            this.labelrent.TabIndex = 12;
            this.labelrent.Text = "label";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel3;
        private Panel panel4;
        private Label Register;
        private Label label1;
        private Label labelrent;
    }
}