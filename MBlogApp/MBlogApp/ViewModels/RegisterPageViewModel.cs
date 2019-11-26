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

		private RegisterModel registerModel;
		public RegisterModel RegisterModel
		{
			get { return registerModel; }
			set
			{
				if (value != registerModel)
				{
					registerModel = value;
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
		public RegisterPageViewModel()
		{
			registerModel = new RegisterModel();
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
			string error = "Email wrong!";
			string emailInput = RegisterModel.Email;
			string passwordInput = RegisterModel.PassWord;
			ErrorMessage = error;
			if ((RegisterModel.Email == "te@te.test") && (RegisterModel.PassWord == "123456789"))
			{
				ErrorMessage = "";
				await App.Current.MainPage.Navigation.PopAsync();
			}
			else
			{
				ErrorMessage = error;
			}
			RegisterModel.ErrorMessage = error;
			
		}		
	}
}
