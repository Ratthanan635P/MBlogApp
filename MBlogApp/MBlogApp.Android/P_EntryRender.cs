﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MBlogApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(Entry), typeof(P_EntryRender))]
namespace MBlogApp.Droid
{
	public class P_EntryRender : EntryRenderer
	{
		public P_EntryRender(Context context) : base(context)
		{

		}
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
			}
		}


	}
}