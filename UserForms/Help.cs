using Models;
using Services.SendGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserForms
{ 
    public partial class Help : Form
    {
        private readonly EmailService emailServices;

        public Help()
        {
            InitializeComponent();
            emailServices = new EmailService();
        }
        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }
        private async void SendMailBTN_Click(object sender, EventArgs e)
        {
            var to = emailcombobox.Texts;
            var subject = emailtextbox.Texts;
            var message = emailmesajbox.Text + " " + _user.username + "";
            var from = "rcroitoru20@outlook.com";

            await emailServices.sendemail(from, to, subject, message);
        }
    }
}
