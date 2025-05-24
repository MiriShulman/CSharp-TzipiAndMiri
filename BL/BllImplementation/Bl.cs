using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllImplementation
{
    public class Bl : IBL
    {
        public IProduct Product => new ImplementationProduct();

        public ICustomer Customer => new ImplementationCustomer();

        public ISale Sale => new ImplementationSale();

        public IOrder Order => new ImplementationOrder();
    }
}
