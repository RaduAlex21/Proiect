using CustomInjection;
using Models;
using Ninject;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserForms
{
    public partial class MyRent : Form
    {

        private readonly IInvoiceServices invoiceServices;  
       // private readonly IRentalServices rentalServices;
        private string con = @"Data Source=Alexandru;Initial Catalog=concurs;Integrated Security=True";

        private string a;
        private string b; 
        private string d;

        public MyRent()
        {
            InitializeComponent();

            invoiceServices = Kernel.Instance.Get<InvoiceServices>(); 
           // rentalServices = Kernel.Instance.Get<RentalServices>();
        }
        
        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            FConfirm(); FupdDate();
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                IdConfirmBox.Texts = row.Cells["id"].Value.ToString();

                a = row.Cells["bike_type"].Value.ToString();
                b = row.Cells["start_date_time"].Value.ToString(); 
                d = row.Cells["price_per_minute"].Value.ToString();
            }
        }

        private void IdConfirmBox__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gridview()
        {
            SqlConnection sql = new SqlConnection(con);
            string sqlselect = "select Rentals.id , bike_type , start_date_time , price_per_minute from Rentals" +
                   " left join Customers on Rentals.customer_id = Customers.id" +
                   " left join Bikes on Rentals.bike_id = Bikes.id " +
                   " where customersname = '" + _user.customersname + "'";
            sql.Open();
            SqlCommand cmd = new SqlCommand(sqlselect, sql);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            dap.Fill(dt);
            datagridview.DataSource = dt;
            cmd.ExecuteNonQuery();
            sql.Close();
        } 
        
        private void FConfirm()
        {
            var confirm = new Invoice()
            {
                rentals_id = int.Parse(IdConfirmBox.Texts.ToString()),

                grass_amount = 100,
                vat = 19,
                net_ammount = 85,
                paid = true,
            }; 
        }
         
        private void FupdDate()
        {
            SqlConnection sqlu = new SqlConnection(con);
            string sqlselectu = "update Rentals set end_date_time = '" + EndDate.Value.ToString() + "' where id = '" + IdConfirmBox.Texts +  "'";
            sqlu.Open();
            SqlCommand cmd = new SqlCommand(sqlselectu, sqlu);
            cmd.ExecuteNonQuery();
            sqlu.Close();
        }

        private void MyRent_Load(object sender, EventArgs e)
        {
            gridview();
        }
    }
}
