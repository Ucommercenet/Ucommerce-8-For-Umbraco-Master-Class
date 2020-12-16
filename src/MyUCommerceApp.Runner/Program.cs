using System;
using System.Linq;
using MyUCommerceApp.BusinessLogic.Queries;
using NHibernate.Linq;
using UCommerce.EntitiesV2;
using UCommerce.Infrastructure;

namespace MyUCommerceApp.Integration
{
	class Program
	{
		static void Main(string[] args)
		{
            var firstOrder = PurchaseOrder.All().First();
        }
	}
}
