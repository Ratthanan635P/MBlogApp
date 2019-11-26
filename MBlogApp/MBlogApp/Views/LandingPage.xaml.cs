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
		}
		private async void ActionImage()
		{
			await Img_Logo.FadeTo(1, 2000);
			await Task.Delay(200);
			await Navigation.PushAsync(new LogInPage());					
		}		
		protected override void OnAppearing()
        {
			base.OnAppearing();
			ActionImage();
		}
	}
}