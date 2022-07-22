namespace ConcursDrx.UserForms
{
    partial class LocateBike
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Location = new CustomControls.RJControls.TextBoxDesign();
            this.ViewBTN = new CustomControls.RJControls.ButtonDesign();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 69);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(876, 419);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.SystemColors.Window;
            this.Location.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.Location.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.Location.BorderRadius = 15;
            this.Location.BorderSize = 1;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Location.Location = new System.Drawing.Point(12, 22);
            this.Location.Margin = new System.Windows.Forms.Padding(4);
            this.Location.Multiline = false;
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Location.PasswordChar = false;
            this.Location.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Location.PlaceholderText = "Your location";
            this.Location.Size = new System.Drawing.Size(734, 31);
            this.Location.TabIndex = 1;
            this.Location.Texts = "";
            this.Location.UnderlinedStyle = false;
            // 
            // ViewBTN
            // 
            this.ViewBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.ViewBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.ViewBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ViewBTN.BorderRadius = 15;
            this.ViewBTN.BorderSize = 0;
            this.ViewBTN.FlatAppearance.BorderSize = 0;
            this.ViewBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBTN.ForeColor = System.Drawing.Color.Black;
            this.ViewBTN.Location = new System.Drawing.Point(753, 22);
            this.ViewBTN.Name = "ViewBTN";
            this.ViewBTN.Size = new System.Drawing.Size(135, 31);
            this.ViewBTN.TabIndex = 2;
            this.ViewBTN.Text = "View";
            this.ViewBTN.TextColor = System.Drawing.Color.Black;
            this.ViewBTN.UseVisualStyleBackColor = false;
            this.ViewBTN.Click += new System.EventHandler(this.ViewBTN_Click);
            // 
            // LocateBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.ViewBTN);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.webView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocateBike";
            this.Text = "LocateBike";
            this.Load += new System.EventHandler(this.LocateBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private CustomControls.RJControls.TextBoxDesign Location;
        private CustomControls.RJControls.ButtonDesign ViewBTN;
    }
}