using MBlogApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MBlogApp.ViewModels
{
	public class ForgotPasswordCompletePageViewModel : BaseViewModel
	{
		public ICommand RegisterCommand { get; set; }
		public ICommand SendEmailCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public ICommand BackPageCommand { get; set; }
		public ICommand LogInCommand { get; set; }
		public ForgotPasswordCompletePageViewModel()
		{
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
			BackPageCommand = new Command(BackPage);
			LogInCommand = new Command(GotoLogInPage);
		}
		private async void GotoForgotPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
		}
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
		//private async void BackPage()
		//{
		//	await App.Current.MainPage.Navigation.PushAsync(new LogInPage());
		//}
		private async void GotoLogInPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new LogInPage());
		}
	}
}
