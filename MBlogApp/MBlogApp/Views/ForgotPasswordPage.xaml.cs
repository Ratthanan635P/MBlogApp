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
	public partial class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage()
		{
			InitializeComponent();		
			//btnSend.IsEnabled = false;
		}

		private void EntryEmail_Focused(object sender, FocusEventArgs e)
		{
			fEmail.BorderColor = Color.FromHex("#1A6B69");
		}

		private void EntryEmail_Unfocused(object sender, FocusEventArgs e)
		{
			fEmail.BorderColor = Color.Gray;
		}
	}
}