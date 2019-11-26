using MBlogApp.Models;
using MBlogApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBlogApp.Services.Implements
{
	public class UserService : IUserService
	{
		public UserModel GetPasswordByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public UserModel LogInUser(LogInModel user)
		{
			throw new NotImplementedException();
		}

		public UserModel RegisterUser(RegisterModel user)
		{
			throw new NotImplementedException();
		}
	}
}
