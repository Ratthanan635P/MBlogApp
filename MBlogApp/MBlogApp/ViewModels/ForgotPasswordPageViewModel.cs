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

	//	public event PropertyChangedEventHandler PropertyChanged;

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
		public ForgotPasswordPageViewModel()
		{
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
		//private async void BackPage()
		//{
		//	await App.Current.MainPage.Navigation.PopAsync();
		//}
		private async void SendEmailPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordCompletePage());
		}
		//protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		//{
		//	var changed = PropertyChanged;
		//	if (changed == null)
		//		return;
		//	changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

		//}
	}
}
