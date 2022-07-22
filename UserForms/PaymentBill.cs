using CustomInjection;
using Dapper;
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
    public partial class PaymentBill : Form
    {
        private readonly IInvoiceServices invoiceServices;

        private string a, b, c, d;
        private decimal x, f;
        private bool g;
        private int invid;

        public PaymentBill()
        {
            InitializeComponent();

            invoiceServices = Kernel.Instance.Get<InvoiceServices>();
        }

        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            
            DialogResult result = printDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void PaymentBell_Load(object sender, EventArgs e)
        {
            gridview();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private string con = @"Data Source=Alexandru;Initial Catalog=concurs;Integrated Security=True";

        private void gridview()
        {
            using var connection = new SqlConnection(con);
            var result = connection.Query<displaybill>("displaybill", new
            {
                test = _user.customersname
            }, commandType: CommandType.StoredProcedure);
            datagridview.DataSource = result;
        } 
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Your Bill : " + a, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Bike : " + b, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 50));
            e.Graphics.DrawString("Start date : " + c, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 100));
            e.Graphics.DrawString("End Date : " + d, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 150));
            e.Graphics.DrawString("Price per minute : " + x, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 200));
            e.Graphics.DrawString("Amount : " + f, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 250));
            e.Graphics.DrawString("Paid : " + g, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 300));
            e.Graphics.DrawString("Bill Id : " + invid, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(15, 350));
        }
         
        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                IdConfirmBox.Texts = row.Cells["id"].Value.ToString(); invid = int.Parse(row.Cells["id"].Value.ToString());

                a = row.Cells["customersname"].Value.ToString();
                b = row.Cells["bike_type"].Value.ToString();
                c = row.Cells["start_date_time"].Value.ToString();
                d = row.Cells["end_date_time"].Value.ToString();
                x = decimal.Parse(row.Cells["price_per_minute"].Value.ToString());
                f = decimal.Parse(row.Cells["grass_amount"].Value.ToString());
                g = bool.Parse(row.Cells["paid"].Value.ToString());
            }
        }
    }
}
