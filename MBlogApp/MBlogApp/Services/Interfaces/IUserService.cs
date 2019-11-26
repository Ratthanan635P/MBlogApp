using MBlogApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBlogApp.Services.Interfaces
{
	public interface IUserService
	{
		UserModel LogInUser(LogInModel user);
		UserModel RegisterUser(RegisterModel user);
		UserModel GetPasswordByEmail(string email);
	}
}
