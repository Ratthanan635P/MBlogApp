﻿using MBlogApp.Services.Implements;
using MBlogApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MBlogApp
{
	public partial class App : Application
	{
		
		public App()
		{
			DependencyService.Register<MockUserService>();
			InitializeComponent();
			
			MainPage = new NavigationPage( new LogInPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
