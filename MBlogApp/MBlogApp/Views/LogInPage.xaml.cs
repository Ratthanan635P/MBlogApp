﻿using MBlogApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MBlogApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogInPage : ContentPage
	{
		public LogInPage()
		{
			InitializeComponent();
			ActionImage();
		}
		private async void ActionImage()
		{
			await Task.WhenAll(
				fEmail.TranslateTo(0, 100, 50, Easing.SpringIn),
				fPassword.TranslateTo(0,100, 50, Easing.SpringIn),
				BtnLogIn.TranslateTo(0, 100, 50, Easing.SpringIn),
				LbForgot.TranslateTo(0, 100, 50, Easing.SpringIn),
				LbRegister.TranslateTo(0, 100, 50, Easing.SpringIn),
				Img_Logo.TranslateTo(0, 100, 50, Easing.SpringIn)
				);
			Img_Logo.IsVisible = true;
			await Task.WhenAll(
			Img_Logo.FadeTo(1, 2500),
			 Img_Logo.TranslateTo(0, 0, 500, Easing.Linear)		
			);
			await Task.Delay(200);
			fEmail.IsVisible = true;
			fPassword.IsVisible = true;
			BtnLogIn.IsVisible = true;
			LbForgot.IsVisible = true;
			LbRegister.IsVisible = true;
			await Task.WhenAll(
				fEmail.TranslateTo(0, 0,500,Easing.Linear),
				fPassword.TranslateTo(0, 0, 500, Easing.Linear),
				BtnLogIn.TranslateTo(0, 0, 500, Easing.Linear),
				LbForgot.TranslateTo(0, 0, 500, Easing.Linear),
				LbRegister.TranslateTo(0, 0, 500, Easing.Linear)
				);
				 
				  
		}
		private void EntryEmail_Focused(object sender, FocusEventArgs e)
		{
			fEmail.BorderColor = Color.FromHex("#1A6B69");
			//EntryEmail.Focus();
		}

		private void EntryEmail_Unfocused(object sender, FocusEventArgs e)
		{
			fEmail.BorderColor = Color.Gray;
		}

		private void EntryPassword_Focused(object sender, FocusEventArgs e)
		{
			fPassword.BorderColor = Color.FromHex("#1A6B69");
		}

		private void EntryPassword_Unfocused(object sender, FocusEventArgs e)
		{
			fPassword.BorderColor = Color.Gray;
		}
	}
}