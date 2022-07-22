using Dapper;
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

namespace ConcursDrx.AdministratorForms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private string conn = @"Data Source=Alexandru;Initial Catalog=concurs;Integrated Security=True";

        private void scooter()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "exec AllVeh";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labelscooter.Text = null;
            labelscooter.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void bill()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "exec AllRent";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labelbill.Text = null;
            labelbill.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void income()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "exec Amount";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labelincome.Text = null;
            labelincome.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void people()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string sql = "exec AllUsers";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            labelpeople.Text = null;
            labelpeople.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            scooter(); bill(); income(); people();
        }
    }
}
