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

namespace ConcursDrx.AdministratorForms
{
    public partial class AddBike : Form
    {
        private readonly IBikeServices bikeServices; 
        public AddBike()
        {
            InitializeComponent();

            bikeServices = Kernel.Instance.Get<BikeServices>();
            
        }

        private void InsertBike_Click(object sender, EventArgs e)
        {
            bike();  
        }

        public void bike()
        {
            var bike = new Bike()
            {
                bike_type = typebox.Texts,
                bike_description = descriptionbox.Texts,
                price_per_minute = decimal.Parse(priceperminbox.Texts),
                register_date = DateTime.Parse(regdatebox.Text.ToString())
            };

            bikeServices.insertBike(bike);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            typebox.Texts = "1 - Bike";
            descriptionbox.Texts = "Viteza maxima 20 km/h";
            priceperminbox.Texts = "1";
            regdatebox.Text = DateTime.Now.ToString();
        }

        private void AddBike_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            typebox.Texts = "2 - Electric-Bike";
            descriptionbox.Texts = "Viteza maxima 40 km/h";
            priceperminbox.Texts = "4";
            regdatebox.Text = DateTime.Now.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            typebox.Texts = "3 - Scooter";
            descriptionbox.Texts = "Viteza maxima 25 km/h";
            priceperminbox.Texts = "2";
            regdatebox.Text = DateTime.Now.ToString();
        }
    }
}
