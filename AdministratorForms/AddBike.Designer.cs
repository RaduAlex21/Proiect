namespace ConcursDrx.AdministratorForms
{
    partial class AddBike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBike));
            this.InsertBike = new CustomControls.RJControls.ButtonDesign();
            this.regdatebox = new LicentaFacultate.Controls.DateTimeDesign();
            this.priceperminbox = new CustomControls.RJControls.TextBoxDesign();
            this.descriptionbox = new CustomControls.RJControls.TextBoxDesign();
            this.typebox = new LicentaFacultate.Controls.ComboBoxDesign();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertBike
            // 
            this.InsertBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.InsertBike.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.InsertBike.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.InsertBike.BorderRadius = 15;
            this.InsertBike.BorderSize = 0;
            this.InsertBike.FlatAppearance.BorderSize = 0;
            this.InsertBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBike.ForeColor = System.Drawing.Color.Black;
            this.InsertBike.Location = new System.Drawing.Point(196, 389);
            this.InsertBike.Name = "InsertBike";
            this.InsertBike.Size = new System.Drawing.Size(169, 40);
            this.InsertBike.TabIndex = 0;
            this.InsertBike.Text = "Add Bike";
            this.InsertBike.TextColor = System.Drawing.Color.Black;
            this.InsertBike.UseVisualStyleBackColor = false;
            this.InsertBike.Click += new System.EventHandler(this.InsertBike_Click);
            // 
            // regdatebox
            // 
            this.regdatebox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.regdatebox.BorderSize = 0;
            this.regdatebox.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regdatebox.Location = new System.Drawing.Point(182, 146);
            this.regdatebox.MinimumSize = new System.Drawing.Size(0, 35);
            this.regdatebox.Name = "regdatebox";
            this.regdatebox.Size = new System.Drawing.Size(200, 35);
            this.regdatebox.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.regdatebox.TabIndex = 6;
            this.regdatebox.TextColor = System.Drawing.Color.White;
            // 
            // priceperminbox
            // 
            this.priceperminbox.BackColor = System.Drawing.Color.White;
            this.priceperminbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.priceperminbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.priceperminbox.BorderRadius = 15;
            this.priceperminbox.BorderSize = 1;
            this.priceperminbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceperminbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceperminbox.Location = new System.Drawing.Point(182, 228);
            this.priceperminbox.Margin = new System.Windows.Forms.Padding(4);
            this.priceperminbox.Multiline = false;
            this.priceperminbox.Name = "priceperminbox";
            this.priceperminbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.priceperminbox.PasswordChar = false;
            this.priceperminbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceperminbox.PlaceholderText = "Price / min";
            this.priceperminbox.Size = new System.Drawing.Size(200, 31);
            this.priceperminbox.TabIndex = 7;
            this.priceperminbox.Texts = "";
            this.priceperminbox.UnderlinedStyle = false;
            // 
            // descriptionbox
            // 
            this.descriptionbox.BackColor = System.Drawing.Color.White;
            this.descriptionbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.descriptionbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.descriptionbox.BorderRadius = 15;
            this.descriptionbox.BorderSize = 1;
            this.descriptionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionbox.Location = new System.Drawing.Point(144, 312);
            this.descriptionbox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionbox.Multiline = false;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.descriptionbox.PasswordChar = false;
            this.descriptionbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.descriptionbox.PlaceholderText = "Description";
            this.descriptionbox.Size = new System.Drawing.Size(273, 31);
            this.descriptionbox.TabIndex = 8;
            this.descriptionbox.Texts = "";
            this.descriptionbox.UnderlinedStyle = false;
            // 
            // typebox
            // 
            this.typebox.BackColor = System.Drawing.Color.White;
            this.typebox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.typebox.BorderSize = 1;
            this.typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.typebox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typebox.ForeColor = System.Drawing.Color.DimGray;
            this.typebox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.typebox.Items.AddRange(new object[] {
            "1 - Bike",
            "2 - Electric-Bike",
            "3 - Scooter"});
            this.typebox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.typebox.ListTextColor = System.Drawing.Color.DimGray;
            this.typebox.Location = new System.Drawing.Point(182, 73);
            this.typebox.MinimumSize = new System.Drawing.Size(200, 30);
            this.typebox.Name = "typebox";
            this.typebox.Padding = new System.Windows.Forms.Padding(1);
            this.typebox.Size = new System.Drawing.Size(200, 30);
            this.typebox.TabIndex = 9;
            this.typebox.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 120);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(624, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 120);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(624, 347);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 120);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AddBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.priceperminbox);
            this.Controls.Add(this.regdatebox);
            this.Controls.Add(this.InsertBike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBike";
            this.Text = "AddBike";
            this.Load += new System.EventHandler(this.AddBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.ButtonDesign InsertBike;
        private LicentaFacultate.Controls.DateTimeDesign regdatebox;
        private CustomControls.RJControls.TextBoxDesign priceperminbox;
        private CustomControls.RJControls.TextBoxDesign descriptionbox;
        private LicentaFacultate.Controls.ComboBoxDesign typebox;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}