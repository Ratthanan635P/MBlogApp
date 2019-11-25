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
	public partial class LandingPage : ContentPage
	{
		 public LandingPage()
		{
			InitializeComponent();
			Test();
		 	Task.Delay(3000);
            Navigation.PushAsync( new LogInPage());
		}
		private async void Test()
		{
			Img_Logo.Opacity = 1;
			await Img_Logo.FadeTo(25, 4000);			
		}
	}
}