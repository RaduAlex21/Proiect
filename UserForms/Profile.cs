using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursDrx.UserForms
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private Customer _user;
        public void username(Customer customer)
        {
            _user = customer;
        }
        private string conn = @"Data Source=Alexandru;Initial Catalog=concurs;Integrated Security=True";
        private void rent()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open(); 
            string sql = "select count(customer_id) from Rentals inner join Customers on Rentals.customer_id = Customers.id where customersname = '" + _user.customersname + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labelrent.Text = null;
            labelrent.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        private void Profile_Load(object sender, EventArgs e)
        {
            rent();
            label1.Text = _user.customersname;
        }
    }
}
