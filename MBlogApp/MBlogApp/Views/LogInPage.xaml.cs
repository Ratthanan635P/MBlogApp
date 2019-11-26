using MBlogApp.ViewModels;
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
			//BindingContext = new LogInPageViewModel();
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