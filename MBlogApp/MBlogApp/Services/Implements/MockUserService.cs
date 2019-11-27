using MBlogApp.Models;
using MBlogApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBlogApp.Services.Implements
{
	public class MockUserService : IUserService
	{
		private List<DataUserModel> ListUser;
		public MockUserService()
		{
			ListUser = new List<DataUserModel>();

			for (int i = 1; i <= 20; i++)
			{
				ListUser.Add(new DataUserModel()
				{
					Id = i,
					Email = "TEST" + i + "@TEST.TEST",
					Password = "Password0"+i
				}); 
			}
		}
		public UserModel GetPasswordByEmail(string email)
		{
			UserModel userModel = new UserModel();
			if (email != null)
			{
				var password = ListUser.Where(u => u.Email == email.ToUpper()).Select(u => u.Password).FirstOrDefault();
				
				if (String.IsNullOrEmpty(password))
				{
					userModel = new UserModel()
					{
						StatusRespond = "404",
						ErrorMessage = "Not found Account !"
					};
				}
				else
				{
					 userModel = new UserModel()
					{
						Password = password,
						StatusRespond = "200",
						ErrorMessage = "OK"
					};
				}
			}
			else
			{
				userModel = new UserModel()
				{ 
					StatusRespond="400",
					ErrorMessage=""
	            };
				
			}
			return userModel;
		}

		public UserModel LogInUser(LogInModel user)
		{
			UserModel userModel = new UserModel();
			if (user != null)
			{


				var password = ListUser.Where(u => u.Email == user.Email.ToUpper()).Select(u => u.Password).FirstOrDefault();

				if (String.IsNullOrEmpty(password))
				{
					userModel = new UserModel()
					{
						StatusRespond = "404",
						ErrorMessage = "Not Found Account!"
					};
				}
				else
				{
					var userId = ListUser.Where(u => u.Email == user.Email.ToUpper() && u.Password == user.PassWord).Select(u => u.Id).FirstOrDefault();

					if (userId == 0)
					{
						userModel = new UserModel()
						{
							StatusRespond = "404",
							ErrorMessage = "Check Password Agian"
						};
					}
					else
					{
						userModel = new UserModel()
						{
							UserId = userId,
							StatusRespond = "200",
							ErrorMessage = "OK"
						};
					}
				}
				
			}
			else
			{
				userModel = new UserModel()
				{
					StatusRespond = "400",
					ErrorMessage = "Parameter Fail!"
				};

			}
			return userModel;
		}

		public UserModel RegisterUser(RegisterModel user)
		{
			UserModel userModel = new UserModel();
			if (user != null)
			{
				if (user.PassWord == user.ConfirmPassWord)
				{
					var userId = ListUser.Where(u => u.Email == user.Email.ToUpper() ).Select(u => u.Id).FirstOrDefault();
					if (userId != 0)
					{
						userModel = new UserModel()
						{
							StatusRespond = "404",
							ErrorMessage = "Email is Exist !"
						};
					}
					else
					{
						//int ListUser.Max(c => c.Id) + 1;
						ListUser.Add(new DataUserModel()
						{
							Id = ListUser.Max(c=>c.Id)+1,
							Email = user.Email.ToUpper(),
							Password = user.PassWord
						});
						userModel = new UserModel()
							{
								
								StatusRespond = "200",
								ErrorMessage = "OK"
							};
						
					}
				}
				else
				{
					userModel = new UserModel()
					{
						StatusRespond = "400",
						ErrorMessage = "Password and ConfirmPassword not same!"
					};
				}
			}
			else
			{
				userModel = new UserModel()
				{
					StatusRespond = "400",
					ErrorMessage = "Parameter Fail!"
				};

			}
			return userModel;
		}
	}
}
