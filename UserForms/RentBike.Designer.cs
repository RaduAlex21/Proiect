namespace ConcursDrx.UserForms
{
    partial class RentBike
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.StartDate = new LicentaFacultate.Controls.DateTimeDesign();
            this.RentBTN = new CustomControls.RJControls.ButtonDesign();
            this.label2 = new System.Windows.Forms.Label();
            this.BikeID = new CustomControls.RJControls.TextBoxDesign();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridview.BackgroundColor = System.Drawing.Color.White;
            this.datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle7;
            this.datagridview.GridColor = System.Drawing.Color.Gainsboro;
            this.datagridview.Location = new System.Drawing.Point(12, 115);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(194)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridview.RowTemplate.Height = 25;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.ShowEditingIcon = false;
            this.datagridview.Size = new System.Drawing.Size(876, 373);
            this.datagridview.TabIndex = 18;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // StartDate
            // 
            this.StartDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StartDate.BorderSize = 0;
            this.StartDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDate.Location = new System.Drawing.Point(324, 41);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 35);
            this.StartDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.StartDate.TabIndex = 19;
            this.StartDate.TextColor = System.Drawing.Color.White;
            // 
            // RentBTN
            // 
            this.RentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.RentBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(160)))), ((int)(((byte)(117)))));
            this.RentBTN.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RentBTN.BorderRadius = 15;
            this.RentBTN.BorderSize = 0;
            this.RentBTN.FlatAppearance.BorderSize = 0;
            this.RentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentBTN.ForeColor = System.Drawing.Color.Black;
            this.RentBTN.Location = new System.Drawing.Point(579, 41);
            this.RentBTN.Name = "RentBTN";
            this.RentBTN.Size = new System.Drawing.Size(150, 40);
            this.RentBTN.TabIndex = 21;
            this.RentBTN.Text = "Rent";
            this.RentBTN.TextColor = System.Drawing.Color.Black;
            this.RentBTN.UseVisualStyleBackColor = false;
            this.RentBTN.Click += new System.EventHandler(this.RentBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(243, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Start";
            // 
            // BikeID
            // 
            this.BikeID.BackColor = System.Drawing.SystemColors.Window;
            this.BikeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.BikeID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.BikeID.BorderRadius = 15;
            this.BikeID.BorderSize = 1;
            this.BikeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BikeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BikeID.Location = new System.Drawing.Point(13, 78);
            this.BikeID.Margin = new System.Windows.Forms.Padding(4);
            this.BikeID.Multiline = false;
            this.BikeID.Name = "BikeID";
            this.BikeID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.BikeID.PasswordChar = false;
            this.BikeID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BikeID.PlaceholderText = "";
            this.BikeID.Size = new System.Drawing.Size(34, 31);
            this.BikeID.TabIndex = 23;
            this.BikeID.Texts = "";
            this.BikeID.UnderlinedStyle = false;
            // 
            // RentBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.BikeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RentBTN);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.datagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentBike";
            this.Text = "RentBike";
            this.Load += new System.EventHandler(this.RentBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridview;
        private LicentaFacultate.Controls.DateTimeDesign StartDate;
        private CustomControls.RJControls.ButtonDesign RentBTN;
        private Label label2;
        private CustomControls.RJControls.TextBoxDesign BikeID;
    }
}