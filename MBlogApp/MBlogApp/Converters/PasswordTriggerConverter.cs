﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MBlogApp.Converters
{
	public class PasswordTriggerConverter : IValueConverter
	{
		public object Convert(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			if (value == null)
			{				
				return false;
			}
			else
			{
				if ((int)value > 6)
					return true;    // data has been entered
				else
					return false;   // input is empty
			}
		}

		public object ConvertBack(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
