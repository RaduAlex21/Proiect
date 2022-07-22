using CustomInjection;
using DBAcces.Repository;
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

namespace ConcursDrx.UserForms
{
    public partial class RentBike : Form
    {
        // rental services

        private readonly IBikeRepository bikeRepository;
        private readonly IRentalServices rentalServices;
        
        private int idcustomer;

        private string a;
        private string b;
        private decimal c;
        private DateTime d;

        public RentBike()
        {
            InitializeComponent();

            bikeRepository = Kernel.Instance.Get<BikeRepository>();
            rentalServices = Kernel.Instance.Get<RentalServices>();
        }

        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }

        private void RentBike_Load(object sender, EventArgs e)
        {
            datagridview.DataSource = bikeRepository.getAll();
        }

        private void RentBTN_Click(object sender, EventArgs e)
        {
            FRental();    
        }

        public void FRental()
        {
            
            var insertRent = new Rental()
            {
                bike_id = int.Parse(BikeID.Texts),
                customer_id = _user.id,
                
                start_date_time = StartDate.Value.ToString(),
            };

            rentalServices.insertRental(insertRent);
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                BikeID.Texts = row.Cells["id"].Value.ToString();

                a = row.Cells["bike_type"].Value.ToString();
                b = row.Cells["bike_description"].Value.ToString();
                c = decimal.Parse(row.Cells["price_per_minute"].Value.ToString());
                d = DateTime.Parse(row.Cells["register_date"].Value.ToString());
            }
        }
    }
}
