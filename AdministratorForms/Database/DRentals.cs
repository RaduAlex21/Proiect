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
    public partial class DRentals : Form
    {
        private readonly IRentalRepository rentalRepository;

        public DRentals()
        {
            InitializeComponent();

            rentalRepository = Kernel.Instance.Get<RentalRepository>();
        }

        private void DRentals_Load(object sender, EventArgs e)
        {
            datagridview.DataSource = rentalRepository.getAll();
        }
    }
}
