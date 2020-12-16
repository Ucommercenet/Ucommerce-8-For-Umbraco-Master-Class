using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUCommerceApp.BusinessLogic.Integration
{
    public class ConnectionStringLocator : UCommerce.Infrastructure.Configuration.ConnectionStringLocator
    {
        public override string LocateConnectionString()
        {
            return LocateConnectionStringInternal(null);
        }
    }
}
