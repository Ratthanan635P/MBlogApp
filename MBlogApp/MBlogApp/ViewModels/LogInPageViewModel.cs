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
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand LogInCommand { get; set; }
		public LogInPageViewModel()
		{
			logInModel = new LogInModel();
			ErrorMessage = "";
			Loading = false;
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
			Loading = true;
			ErrorMessage = "";
			string error = "";
			if (!((CheckRegEx_UserName(LogInModel.Email))&&(LogInModel.Email.Length>LengthEmail)))
			{
				error = " Email is Invalid!";

			}
			if (!((CheckRegEx_Password(LogInModel.PassWord)) && (LogInModel.PassWord.Length > LengthPassword)))
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
				var result = UserService.LogInUser(LogInModel);
				if (result.StatusRespond == "200")
				{
					ErrorMessage = "";					
					await Task.Delay(3000);
					Loading = false;
					await App.Current.MainPage.Navigation.PushAsync(new MainPage());
				}
				else
				{
					await Task.Delay(3000);
					error = "No Account Email";
					ErrorMessage = error;
					Loading = false;
				}
			}
			else
			{
				await Task.Delay(1500);
				ErrorMessage = error;
				Loading = false;
			}
		   //	await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
	}
}
