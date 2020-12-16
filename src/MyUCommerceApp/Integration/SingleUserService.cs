using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using UCommerce.EntitiesV2;
using UCommerce.Security;

namespace MyUCommerceApp.BusinessLogic.Integration
{
	public class SingleUserService : IUserService
	{
		private readonly string _username;

		public SingleUserService(string username)
		{
			_username = username;
		}

		public User GetCurrentUser()
		{
			return new User(GetCurrentUserName());
		}

		public User GetUser(string userName)
		{
			throw new NotImplementedException();
		}

		public IList<User> GetAllUsers()
		{
			throw new NotImplementedException();
		}

		public string GetCurrentUserName()
		{
			return _username;
		}

		public CultureInfo GetCurrentUserCulture()
		{
			return CultureInfo.InvariantCulture;
		}
	}
}
