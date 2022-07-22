using CustomInjection;
using Ninject;
using Services.SendGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    public partial class ChangePassword : Form
    {
        private readonly EmailService emailServices;

        string randomCode;

        public ChangePassword()
        {
            InitializeComponent();

            emailServices = Kernel.Instance.Get<EmailService>();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            FCase1();
        }
          
        private async void emailcode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomCode = (random.Next(99999)).ToString();

            var to = EmailBox.Texts;
            var subject = "verify code";
            var message = "Your code is : " + randomCode;
            var from = "rcroitoru20@outlook.com";

            await emailServices.sendemail(from, to, subject, message);
        }

        private void VerifyCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (CodeBox.Texts).ToString())
            {
                FCase2(); FCase3();
            }
            else
            {
                MessageBox.Show("Eroare"); 
            }
        }

        private void FCase1()
        {
            label1.Visible = false;
            email.Visible = false;
            newpassword.Visible = false;
            toggleBtnDesign1.Visible = false;
            ChangePW.Visible = false;
        }

        public void FCase2()
        {
            EmailBox.Visible = false;
            CodeBox.Visible = false;
            VerifyCode.Visible = false;
            emailcode.Visible = false;
        }

        private void FCase3()
        {
            label1.Visible = true;
            email.Visible = true;
            newpassword.Visible = true;
            toggleBtnDesign1.Visible = true;
            ChangePW.Visible = true;
        }

        private string con = @"Data Source=Alexandru;Initial Catalog=concurs;Integrated Security=True";

        private void ChangePW_Click(object sender, EventArgs e)
        {
            if (newpassword.Texts == newpassword.Texts)
            {
                SqlConnection conn = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Update Customers set password = '" + newpassword.Texts + "' where username = '" + email.Texts + "' ", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succes"); 
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void toggleBtnDesign1_CheckedChanged(object sender, EventArgs e)
        {
            switch (toggleBtnDesign1.Checked)
            {
                case false:
                    newpassword.PasswordChar = true;
                    return;
                case true:
                    newpassword.PasswordChar = false;
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
