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

		private RegisterCommand registerModel;
		public RegisterCommand RegisterModel
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
		//public event PropertyChangedEventHandler PropertyChanged;
		public RegisterPageViewModel()
		{
			ForgotCommand = new Command(GotoForgotPage);
			RegisterCommand = new Command(GotoRegisterPage,()=>false);
			BackPageCommand = new Command(BackPage);
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
		//protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		//{
		//	var changed = PropertyChanged;
		//	if (changed == null)
		//		return;
		//	changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

		//}
	}
}
