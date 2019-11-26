using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MBlogApp.Converters
{
	public class ErrorTriggerConverter : IValueConverter
	{
		public object Convert(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			var error = (string)value;
			if (error == null || error.Length <= 1)
			{
				return false;    // data has been entered
			}
			else
			{
				return true;   // input is empty
			}
		}

		public object ConvertBack(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			var error = (string)value;
			if (error == null || error.Length <= 1)
			{
				return false;    // data has been entered
			}
			else
			{
				return true;   // input is empty
			}
		}
	}
}
