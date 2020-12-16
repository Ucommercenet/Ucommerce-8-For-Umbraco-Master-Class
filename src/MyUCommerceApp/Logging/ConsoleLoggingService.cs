using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCommerce.Infrastructure.Logging;

namespace MyUCommerceApp.BusinessLogic.Logging
{
    public class ConsoleLoggingService : ILoggingService
    {
        public void Log<T>(string customMessage)
        {
            Console.WriteLine(customMessage);
        }

        public void Log<T>(Exception exception)
        {
            Console.WriteLine(exception);
            throw new NotImplementedException();
        }

        public void Log<T>(Exception exception, string customMessage)
        {
            Console.WriteLine(customMessage);
            Console.WriteLine(exception);
        }
    }
}
