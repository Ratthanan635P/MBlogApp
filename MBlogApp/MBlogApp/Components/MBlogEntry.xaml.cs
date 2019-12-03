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
	public partial class MBlogEntry : ContentView
	{
		public MBlogEntry()
		{
			InitializeComponent();
		}
		public static readonly BindableProperty TextLabelProperty =
							BindableProperty.Create(nameof(TextLabel),
													typeof(string),
													typeof(MBlogEntry),
													default(string), defaultBindingMode: BindingMode.TwoWay);
		public string TextLabel
		{
			get { return (string)GetValue(TextLabelProperty); }
			set { SetValue(TextLabelProperty, value); }
		}
		public static readonly BindableProperty TextEntryProperty =
							  BindableProperty.Create(nameof(TextEntry),
													  typeof(string),
													  typeof(MBlogEntry),
													  default(string),defaultBindingMode:BindingMode.TwoWay);
		public string TextEntry
		{
			get { return (string)GetValue(TextEntryProperty); }
			set { SetValue(TextEntryProperty, value); }
		}
		//public static readonly BindableProperty VisibleFrameProperty =
		//					  BindableProperty.Create(nameof(VisibleFrame),
		//											  typeof(bool),
		//											  typeof(MBlogEntry),
		//											  default(bool));
		//public bool VisibleFrame
		//{
		//	get { return (bool)GetValue(VisibleFrameProperty); }
		//	set { SetValue(VisibleFrameProperty, value); }
		//}
		public static readonly BindableProperty PasswordEntryProperty =
							  BindableProperty.Create(nameof(PasswordEntry),
													  typeof(bool),
													  typeof(MBlogEntry),
													  default(bool));
		public bool PasswordEntry
		{
			get { return (bool)GetValue(PasswordEntryProperty); }
			set { SetValue(PasswordEntryProperty, value); }
		}
		public static readonly BindableProperty PlacehoderProperty =
							  BindableProperty.Create(nameof(Placehoder),
													  typeof(string),
													  typeof(MBlogEntry),
													  default(string));
		public string Placehoder
		{
			get { return (string)GetValue(PlacehoderProperty); }
			set { SetValue(PlacehoderProperty, value); }
		}
	}
}