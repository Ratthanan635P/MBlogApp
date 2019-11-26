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
	public class LogInPageViewModel  :BaseViewModel
	{
		private LogInModel logInModel;
		public LogInModel LogInModel
		{
			get { return logInModel; }
			set
			{
				if (value != logInModel)
				{
					logInModel = value;
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
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand LogInCommand { get; set; }
		public LogInPageViewModel()
		{
			logInModel = new LogInModel();
			errorMessage = "";
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
			LogInCommand = new Command(GotoHomePage,()=>false);
		}

		//public event PropertyChangedEventHandler PropertyChanged;

		private async void GotoForgotPage ()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
		private async void GotoHomePage()
		{
			string error = "";
			if (!((CheckRegEx_UserName(LogInModel.Email))&&(LogInModel.Email.Length>App.LengthEmail)))
			{
				error = " Email is Invalid!";

			}
			if (!((CheckRegEx_Password(LogInModel.PassWord)) && (LogInModel.PassWord.Length > App.LengthPassword)))
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

			//Call Api Check email and Password

			if (error == "")
			{
				if ((LogInModel.Email.ToUpper() == "TEST3@TEST.TEST") && (LogInModel.PassWord == "Gg123456789"))
				{
					ErrorMessage = "";
					await App.Current.MainPage.Navigation.PushAsync(new MainPage());
				}
				else
				{
					error = "No Account Email";
					ErrorMessage = error;
				}
			}
			else
			{
				ErrorMessage = error;				
			}
		   //	await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
	}
}
