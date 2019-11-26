using MBlogApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MBlogApp
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage(DataUserModel dataUser)
		{
			InitializeComponent();
			LbUser.Text = "UserId :" + dataUser.Id;
			LbEmail.Text = "Email User :" + dataUser.Email;
			LbPassword.Text = "Password User :" + dataUser.Password;

		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
