using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MBlogApp.Models
{
	public class LogInModel
	{
		public string Email { get; set; }
		public string PassWord { get; set; }
		public string ErrorMessage { get; set; }

		//private string email;

		//public string Email
		//{
		//	get { return email; }
		//	set {
		//		email = value;
		//		if (!CheckRegEx_UserName(email))
		//		{
		//			ErrorMessage = "error pattarn email fail";
		//		}
				
		//		}
		//}
		//public bool CheckRegEx_UserName(string username)
		//{
		//	var patterns = @"^[a - zA - Z0 - 9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
		//	Regex rx = new Regex(patterns, RegexOptions.IgnoreCase);
		//	return rx.IsMatch(username);
		//}

	}
}
