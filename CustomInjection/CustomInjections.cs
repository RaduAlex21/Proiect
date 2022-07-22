using CustomInjection.Properties;
using DBAcces.Repository;
using DBAcces.SqlDataAccess;
using Ninject.Modules;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInjection
{
    public class CustomInjections : NinjectModule
    {
        public override void Load()
        {
            var connection = Resources.connectionString;

            Bind<IConnection>().ToConstant(new Connection(connection));

            Bind<IAdministratorRepository>().To<AdministratorRepository>(); 
            Bind<IBikeRepository>().To<BikeRepository>();
            Bind<ICustomerRepository>().To<CustomerRepository>();
            Bind<IInvoiceRepository>().To<InvoiceRepository>();
            Bind<IRentalRepository>().To<RentalRepository>();
             

            Bind<IAdministratorServices>().To<AdministratorServices>(); 
            Bind<IBikeServices>().To<BikeServices>();
            Bind<ICustomerServices>().To<CustomerServices>();
            Bind<IInvoiceServices>().To<InvoiceServices>();
            Bind<IRentalServices>().To<RentalServices>();

            
        }
    }
}
