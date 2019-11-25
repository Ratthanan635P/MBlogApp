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
	public class LogInPageViewModel : INotifyPropertyChanged
	{
		//public LogInCommand LogInModel { get; set; }
		private LogInCommand logInModel;
		public LogInCommand LogInModel
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
		public ICommand RegisterCommand { get; set; }
		public ICommand ForgotCommand { get; set; }
		public LogInPageViewModel()
		{
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private async void GotoForgotPage ()
		{
			await App.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }
		private async void GotoRegisterPage()
		{
			await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
		}
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			var changed = PropertyChanged;
			if (changed == null)
				return;
			changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
	}
}
