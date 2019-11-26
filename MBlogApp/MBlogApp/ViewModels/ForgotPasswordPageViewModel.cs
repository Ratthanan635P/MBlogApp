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
	public class ForgotPasswordPageViewModel:BaseViewModel
	{
		public ICommand RegisterCommand { get; set; }
		public ICommand SendEmailCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand BackPageCommand { get; set; }
		private string email="";
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
		private bool loading;
		public bool Loading
		{
			get { return loading; }
			set
			{
				if (value != loading)
				{
					loading = value;
					OnPropertyChanged();
				}
			}
		}
		public ForgotPasswordPageViewModel()
		{
			errorMessage = "";
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
			BackPageCommand = new Command(BackPage);
			//SendEmailCommand=new Command(SendEmailPage,CanSendEmailPage);
			SendEmailCommand=new Command(SendEmailPage,()=>false);
			
		}

		private bool CanSendEmailPage()
		{
			return false;
		}

		private async void GotoForgotPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
		}
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}

		private async void SendEmailPage()
		{
			Loading = true;
			string error = "";
			if (!((CheckRegEx_UserName(Email)) && (Email.Length > LengthEmail)))
			{
				error = " Email is Invalid!";

			}

			//Call Api send email Forgot password	
			await Task.Delay(3000);
			Loading = false;
			if (error == "")
			{
				var result = UserService.GetPasswordByEmail(Email);
				if (result.StatusRespond=="200")
				{
					//PassWord == "Gg123456789";
				
					ErrorMessage = "";
					await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordCompletePage());
				}
				else
				{
					ErrorMessage = result.ErrorMessage;
					Email = "";				
				}
			}
			else
			{
				ErrorMessage = error;
				//Email = "";

			}
			//	await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());

		}
	}
}
