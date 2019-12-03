using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MBlogApp.Components
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MBlogLoading : ContentView
	{
		public MBlogLoading()
		{
			InitializeComponent();
		}
		public static readonly BindableProperty LoadingProperty =
							  BindableProperty.Create(nameof(Loading),
													  typeof(bool),
													  typeof(MBlogLoading),
													  default(bool));
		public bool Loading
		{
			get { return (bool)GetValue(LoadingProperty); }
			set { SetValue(LoadingProperty, value); }
		}
	}
}