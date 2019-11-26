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

			string error = "";
			if (!((CheckRegEx_UserName(Email)) && (Email.Length > App.LengthEmail)))
			{
				error = " Email is Invalid!";

			}
						
			//Call Api send email Forgot password	

			if (error == "")
			{
				if (Email.ToUpper() == "TEST3@TEST.TEST")
				{
					//PassWord == "Gg123456789";
				
					ErrorMessage = "";
					await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordCompletePage());
				}
				else
				{
					ErrorMessage = "";
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
