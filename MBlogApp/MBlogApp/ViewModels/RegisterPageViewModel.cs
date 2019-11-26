using MBlogApp.Models;
using MBlogApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MBlogApp.ViewModels
{
	public class RegisterPageViewModel : BaseViewModel
	{
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand BackPageCommand { get; set; }

		private RegisterModel RegisterModel;
		//public RegisterModel RegisterModel
		//{
		//	get { return registerModel; }
		//	set
		//	{
		//		if (value.PassWord != registerModel.PassWord)
		//		{
		//			registerModel = value;
		//			OnPropertyChanged();
		//		}
		//		if (value.ConfirmPassWord != registerModel.ConfirmPassWord)
		//		{
		//			registerModel = value;
		//			OnPropertyChanged();
		//		}
		//		if (value.Email != registerModel.Email)
		//		{
		//			registerModel = value;
		//			OnPropertyChanged();
		//		}
		//	}
		//}
		private string errorMessage;
		public string ErrorMessage
		{
			get { return errorMessage; }
			set
			{
				if (value != errorMessage)
				{
					errorMessage = value;
					OnPropertyChanged();
				}
			}
		}
		private string email;
		public string Email
		{
			get { return email; }
			set
			{
				if (value != email)
				{
					email = value;
					OnPropertyChanged();
				}
			}
		}
		private string password;
		public string Password
		{
			get { return password; }
			set
			{
				if (value != password)
				{
					password = value;
					OnPropertyChanged();
				}
			}
		}
		private string confirmPassword;
		public string ConfirmPassword
		{
			get { return confirmPassword; }
			set
			{
				if (value != confirmPassword)
				{
					confirmPassword = value;
					OnPropertyChanged();
				}
			}
		}
		public RegisterPageViewModel()
		{
			RegisterModel = new RegisterModel();
			errorMessage = "";
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoLogInPage, ()=>false);
			BackPageCommand = new Command(BackPage);
		}
		private async void GotoForgotPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
		}
		private async void GotoLogInPage()
		{
			string error = "";
			if (!((CheckRegEx_UserName(Email)) && (Email.Length > App.LengthEmail)))
			{
				error = " Email is Invalid!";

			}
			if (!((CheckRegEx_Password(Password)) && (Password.Length > App.LengthPassword)))
			{
				if (error != "")
				{
					error = " Email and Password is Invalid! ";

				}
				else
				{
					error = " Password is Invalid!";
				}
			}

			if (Password != ConfirmPassword)
			{
				if (error == "")
				{
					error = " Password and ConfirmPassword not same!";
					ConfirmPassword = "";
				}
			}

			//Call Api register Check email and Password			

			if (error == "")
			{
				if ((Email.ToUpper() == "TEST3@TEST.TEST") && (Password == "Gg123456789"))
				{
					error = "Email is exist!";
					ErrorMessage = error;
				
					
				}
				else
				{
					ErrorMessage = "";
					//RegisterModel.ErrorMessage = "";

					await App.Current.MainPage.Navigation.PopAsync();
				}
			}
			else
			{
				ErrorMessage = error;

				RegisterModel.ErrorMessage = "";
			}
			//	await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
	}
}
