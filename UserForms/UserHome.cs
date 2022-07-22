using CustomInjection;
using Models;
using Ninject;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserForms;
using Help = UserForms.Help;

namespace ConcursDrx.UserForms
{
    public partial class UserHome : Form
    {
        private readonly ICustomerServices customerServices;

        public UserHome()
        {
            InitializeComponent();

            customerServices = Kernel.Instance.Get<CustomerServices>();
        }

        private Form activeForm = null;
        private void openNewForm(Form newform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newform;
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            interfacepanel.Controls.Add(newform);
            interfacepanel.Tag = newform;
            newform.BringToFront();
            newform.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        } 
        private void ProfileBTN_Click(object sender, EventArgs e)
        {
            var profile = new Profile();
            profile.username(_user);
            openNewForm(profile);
        }

        private void RentBike_Click(object sender, EventArgs e)
        {
            var rentbike = new RentBike();
            rentbike.username(_user);
            openNewForm(rentbike);
        }

        private void LocateBTN_Click(object sender, EventArgs e)
        {
            var locate = new LocateBike();
            locate.username(_user);
            openNewForm(locate);
        } 

        private void MyRentBTN_Click(object sender, EventArgs e)
        {
            var profile = new MyRent();
            profile.username(_user);
            openNewForm(profile);
        }

        private void HelpBTN_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.username(_user);
            openNewForm(help);
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new Login();
            f.Show();
        }

        private void PrintB_Click(object sender, EventArgs e)
        {
            var print = new PaymentBill();
            print.username(_user);
            openNewForm(print);
        }
        private Customer _user;
        public void username(string username)
        {
            _user = customerServices.SearchByUsername(username);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
