using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;
using UCommerce.EntitiesV2;
using UCommerce.Infrastructure.Configuration;
using NHibernate.Linq;
using UCommerce.Security;

namespace MyUCommerceApp.Test
{

	[TestFixture]
	public class QueryTests
	{
		private const string CONNECTIONSTRING = "Data Source=.;Initial Catalog=u6;Integrated Security=true;";

		[Test]
		public void Test()
		{
			var sessionProvider = GetSessionProvider();

			using (var session = sessionProvider.GetSession())
			{
				var order = session.Query<PurchaseOrder>().First();
			}
		}

		private SessionProvider GetSessionProvider()
		{
			var commerceConfigProviderStub = MockRepository.GenerateStub<CommerceConfigurationProvider>();
			commerceConfigProviderStub
				.Stub(x => x.GetRuntimeConfiguration())
				.Return(new RuntimeConfigurationSection
				{
					EnableCache = true,
					CacheProvider = "NHibernate.Caches.SysCache.SysCacheProvider, NHibernate.Caches.SysCache",
					ConnectionString = CONNECTIONSTRING
				});

			var userServiceStub = MockRepository.GenerateStub<IUserService>();
			userServiceStub.Stub(x => x.GetCurrentUser()).Return(new User("system"));
			userServiceStub.Stub(x => x.GetCurrentUserName()).Return("system");

			var sessionProvider = new SessionProvider(commerceConfigProviderStub, userServiceStub, new List<IContainsNHibernateMappingsTag>());

			return sessionProvider;
		}
	}
}