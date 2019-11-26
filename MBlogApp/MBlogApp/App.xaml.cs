using MBlogApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MBlogApp
{
	public partial class App : Application
	{
		public static int LengthEmail { get; private set; }
		public static int LengthPassword { get; private set; }
		public static int LengthMax { get; private set; }
		public App()
		{
			InitializeComponent();
			LengthEmail = 4;
			LengthPassword = 6;
			LengthMax = 50;
			MainPage = new NavigationPage( new LandingPage());
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
