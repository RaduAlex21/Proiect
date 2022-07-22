namespace ConcursDrx.AdministratorForms.Database
{
    partial class DCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.usernamebox = new CustomControls.RJControls.TextBoxDesign();
            this.billingadressbox = new CustomControls.RJControls.TextBoxDesign();
            this.passwordbox = new CustomControls.RJControls.TextBoxDesign();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(811, 402);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 67);
            this.delete.TabIndex = 24;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(689, 402);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(77, 67);
            this.update.TabIndex = 23;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
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
            this.datagridview.Location = new System.Drawing.Point(12, 12);
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
            this.datagridview.Size = new System.Drawing.Size(876, 370);
            this.datagridview.TabIndex = 22;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // usernamebox
            // 
            this.usernamebox.BackColor = System.Drawing.SystemColors.Window;
            this.usernamebox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.usernamebox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.usernamebox.BorderRadius = 15;
            this.usernamebox.BorderSize = 1;
            this.usernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernamebox.Location = new System.Drawing.Point(33, 419);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(4);
            this.usernamebox.Multiline = false;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.usernamebox.PasswordChar = false;
            this.usernamebox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernamebox.PlaceholderText = "";
            this.usernamebox.Size = new System.Drawing.Size(190, 31);
            this.usernamebox.TabIndex = 21;
            this.usernamebox.Texts = "";
            this.usernamebox.UnderlinedStyle = false;
            // 
            // billingadressbox
            // 
            this.billingadressbox.BackColor = System.Drawing.SystemColors.Window;
            this.billingadressbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.billingadressbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.billingadressbox.BorderRadius = 15;
            this.billingadressbox.BorderSize = 1;
            this.billingadressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.billingadressbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.billingadressbox.Location = new System.Drawing.Point(472, 419);
            this.billingadressbox.Margin = new System.Windows.Forms.Padding(4);
            this.billingadressbox.Multiline = false;
            this.billingadressbox.Name = "billingadressbox";
            this.billingadressbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.billingadressbox.PasswordChar = false;
            this.billingadressbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.billingadressbox.PlaceholderText = "";
            this.billingadressbox.Size = new System.Drawing.Size(190, 31);
            this.billingadressbox.TabIndex = 20;
            this.billingadressbox.Texts = "";
            this.billingadressbox.UnderlinedStyle = false;
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(115)))), ((int)(((byte)(106)))));
            this.passwordbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(175)))), ((int)(((byte)(48)))));
            this.passwordbox.BorderRadius = 15;
            this.passwordbox.BorderSize = 1;
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordbox.Location = new System.Drawing.Point(253, 419);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordbox.Multiline = false;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordbox.PasswordChar = false;
            this.passwordbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordbox.PlaceholderText = "";
            this.passwordbox.Size = new System.Drawing.Size(190, 31);
            this.passwordbox.TabIndex = 25;
            this.passwordbox.Texts = "";
            this.passwordbox.UnderlinedStyle = false;
            // 
            // DCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.billingadressbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DCustomers";
            this.Text = "DCustomers";
            this.Load += new System.EventHandler(this.DCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button delete;
        private Button update;
        private DataGridView datagridview;
        private CustomControls.RJControls.TextBoxDesign usernamebox;
        private CustomControls.RJControls.TextBoxDesign billingadressbox;
        private CustomControls.RJControls.TextBoxDesign passwordbox;
    }
}