using CustomInjection;
using DBAcces.Repository;
using Ninject;
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
    public partial class DInvoices : Form
    {
        private readonly IInvoiceRepository invoiceRepository;

        public DInvoices()
        {
            InitializeComponent();

            invoiceRepository = Kernel.Instance.Get<InvoiceRepository>();
        }

        private void DInvoices_Load(object sender, EventArgs e)
        {
            datagridview.DataSource = invoiceRepository.getAll();
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
