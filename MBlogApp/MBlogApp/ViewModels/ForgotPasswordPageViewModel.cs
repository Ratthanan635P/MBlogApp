using MBlogApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MBlogApp.ViewModels
{
	public class ForgotPasswordPageViewModel
	{
		public ICommand RegisterCommand { get; set; }
		public ICommand SendEmailCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand BackPageCommand { get; set; }
		public ForgotPasswordPageViewModel()
		{
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
			BackPageCommand = new Command(BackPage);
			SendEmailCommand=new Command(SendEmailPage);
			
		}
		private async void GotoForgotPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
		}
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
		private async void BackPage()
		{
			await App.Current.MainPage.Navigation.PopAsync();
		}
		private async void SendEmailPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordCompletePage());
		}
	}
}
