using System;
using System.Collections.Generic;
using System.Text;

namespace MBlogApp.Models
{
	public class UserModel
	{
		public int UserId { get; set; }
		public string Password { get; set; }
		public string StatusRespond { get; set; }
		public string ErrorMessage { get; set; }
	}
}
