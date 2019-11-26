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
			//Task.Delay(1000);
			//ActionImage();
		
			
		}
		private async void ActionImage()
		{
			//Img_Logo.Opacity = 1;
			//await Img_Logo.TranslateTo(100, 100, 2500, Easing.BounceIn);
			await Img_Logo.FadeTo(1, 2000);
			await Task.Delay(1000);
			await Navigation.PushAsync(new LogInPage());
						
		}
		private async void ActionImageDefalut()
		{
			//Img_Logo.Opacity = 1;
			//await Img_Logo.TranslateTo(100, 100, 2500, Easing.BounceIn);
			//await Img_Logo.FadeTo(1, 4000);
			await Task.Delay(1000);
			await Navigation.PushAsync(new LogInPage());

		}
		protected override void OnAppearing()
        {
			base.OnAppearing();
			ActionImage();
		}
	}
}