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
    public partial class DCustomers : Form
    {
        private readonly ICustomerServices customerServices;
        private readonly ICustomerRepository customerRepository;

        private int id;
        private string customername;

        public DCustomers()
        {
            InitializeComponent();

            customerServices = Kernel.Instance.Get<CustomerServices>();
            customerRepository = Kernel.Instance.Get<CustomerRepository>();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Fupdate();
        }

        private void DCustomers_Load(object sender, EventArgs e)
        {
            datagridview.DataSource = customerRepository.getAll();
            datagridview.AutoSize = true;
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridview.Rows[e.RowIndex];

                usernamebox.Texts = row.Cells["username"].Value.ToString();
                passwordbox.Texts = row.Cells["password"].Value.ToString();
                billingadressbox.Texts = row.Cells["billing_adress"].Value.ToString();

                id = int.Parse(row.Cells["id"].Value.ToString());
                customername = row.Cells["customersname"].Value.ToString();
            }
        }

        private void Fupdate()
        {
            var update = new Customer()
            {
                id = id,
                customersname = customername,

                username = usernamebox.Texts,
                password = passwordbox.Texts,
                billing_adress = billingadressbox.Texts,
            };

            customerServices.updateCustomer(update);

            datagridview.DataSource = null;
            datagridview.DataSource = customerRepository.getAll();
        }

        private void Fdelete()
        {
            var delete = new Customer()
            {
                id = id,
            };

            customerServices.deleteCustomer(delete);

            datagridview.DataSource = null;
            datagridview.DataSource = customerRepository.getAll();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Fdelete();
        }
    }
}
