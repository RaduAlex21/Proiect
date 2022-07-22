using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursDrx.UserForms
{
    public partial class LocateBike : Form
    {
        public LocateBike()
        {
            InitializeComponent();
        }

        private void LocateBike_Load(object sender, EventArgs e)
        {

        }

        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }
        
        private async Task Init()
        {
            await webView.EnsureCoreWebView2Async(null); 
        }

        private async void Flocation()
        {
            await Init();
            string streetLocation = Location.Texts;

            StringBuilder queryAdress = new StringBuilder();
            queryAdress.Append("https://www.google.com/maps/dir/" + streetLocation.ToString() + "/Parcul+Ștrand,+Pitești/");

            if (streetLocation != string.Empty)
            {
                queryAdress.Append("");
            }

            webView.CoreWebView2.Navigate(queryAdress.ToString());
        }

        private void ViewBTN_Click(object sender, EventArgs e)
        {
            Flocation();
        }
    }
}
