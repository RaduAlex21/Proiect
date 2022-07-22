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

namespace ConcursDrx.AdministratorForms.Database
{
    public partial class DBikes : Form
    {
        private readonly IBikeServices bikeServices;
        private readonly IBikeRepository bikeRepository;


        private DateTime regdate;
        private int id = 0;
        private string biketype;
        public DBikes()
        {
            InitializeComponent();

            bikeServices = Kernel.Instance.Get<BikeServices>();
            bikeRepository = Kernel.Instance.Get<BikeRepository>();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Fupdate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Fdelete();
        }

        private void Fupdate()
        { 
            var update = new Bike()
            {
                id = id,
                bike_type = biketype,
                register_date = regdate,

                bike_description = bikedescriptionbox.Texts,
                price_per_minute = decimal.Parse(priceperminutebox.Texts)
            };

            bikeServices.updateBike(update);

            datagridview.DataSource = null;
            datagridview.DataSource = bikeRepository.getAll();
        }

        private void Fdelete()
        {
            var delete = new Bike()
            {
                id = id
            };

            bikeServices.deleteBike(delete);

            datagridview.DataSource = null;
            datagridview.DataSource = bikeRepository.getAll();
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                bikedescriptionbox.Texts = row.Cells["bike_description"].Value.ToString();
                priceperminutebox.Texts = row.Cells["price_per_minute"].Value.ToString(); 

                id = int.Parse(row.Cells["id"].Value.ToString());
                biketype = row.Cells["bike_type"].Value.ToString();
                regdate = DateTime.Parse(row.Cells["register_date"].Value.ToString());
            }
        }

        private void DBikes_Load(object sender, EventArgs e)
        {
            datagridview.DataSource = bikeRepository.getAll();
            datagridview.AutoSize = true;
        }
    }
}
