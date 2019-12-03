using MBlogApp.Models;
using MBlogApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
		
		public RegisterPageViewModel()
		{
			RegisterModel = new RegisterModel();
			Loading = false;
			errorMessage = "";
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoLogInPage, () => false);
			BackPageCommand = new Command(BackPage);
		}
		private async void GotoForgotPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
		}
		private async void GotoLogInPage()
		{
			Loading = true;
			string error = "";
			if (!((CheckRegEx_UserName(Email)) && (Email.Length > LengthEmail)))
			{
				error = " Email is Invalid!";
			}
			if (!((CheckRegEx_Password(Password)) && (Password.Length > LengthPassword)))
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

			await Task.Delay(3000);
			
			if (error == "")
			{
				RegisterModel = new RegisterModel()
				{
					Email=Email,
					PassWord=Password,
					ConfirmPassWord=ConfirmPassword
				};
				var result = UserService.RegisterUser(RegisterModel);
				if (result.StatusRespond != "200")
				{
					error = result.ErrorMessage;
					ErrorMessage = error;
					Loading = false;
				}
				else
				{
					ErrorMessage = "";
					Loading = false;
					await App.Current.MainPage.DisplayAlert("", "ลงทะเบียนสำเสร็จ", "OK");
					await App.Current.MainPage.Navigation.PopAsync();
				}
			}
			else
			{
				ErrorMessage = error;
				Loading = false;
			}
			//	await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
	}
}
