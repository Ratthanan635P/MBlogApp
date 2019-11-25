using System;
using System.Collections.Generic;
using System.Text;

namespace MBlogApp.Models
{
	public class RegisterCommand
	{
		public string Email { get; set; }
		public string PassWord { get; set; }
		public string ConfirmPassWord { get; set; }
		public string ErrorMessage { get; set; }
	}
}
