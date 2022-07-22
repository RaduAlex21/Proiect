using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursDrx.AdministratorForms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            costumize();
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

        public void costumize()
        {
            submenuDB.Visible = false;
        }
        public void hidesubmenu()
        {
            if (submenuDB.Visible == true)
                submenuDB.Visible = false;
        }


        public void displaysubmenu(Panel submenupanel)
        {
            if (submenupanel.Visible == false)
            {
                hidesubmenu();
                submenupanel.Visible = true;
            }
            else
                submenupanel.Visible = false;
        }

        private void AddBike_Click(object sender, EventArgs e)
        {
            openNewForm(new AddBike());
        }

        private void DataBase_Click(object sender, EventArgs e)
        {
            displaysubmenu(submenuDB);
        }

        private void BtnDBikes_Click(object sender, EventArgs e)
        {
            openNewForm(new Database.DBikes());
        }

        private void BtnDInvoices_Click(object sender, EventArgs e)
        {
            openNewForm(new Database.DInvoices());
        }

        private void BtnDCustomers_Click(object sender, EventArgs e)
        {
            openNewForm(new Database.DCustomers());
        }

        private void BtnDRentals_Click(object sender, EventArgs e)
        {
            openNewForm(new Database.DRentals());
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

        private void DashBoard_Click(object sender, EventArgs e)
        {
            openNewForm(new DashBoard());

        }

        private void interfacepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
