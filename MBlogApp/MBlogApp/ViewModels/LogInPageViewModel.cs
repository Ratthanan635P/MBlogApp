using MBlogApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MBlogApp.ViewModels
{
	public class LogInPageViewModel
	{
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public LogInPageViewModel()
		{
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
		}
		private async void GotoForgotPage ()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
	}
}
