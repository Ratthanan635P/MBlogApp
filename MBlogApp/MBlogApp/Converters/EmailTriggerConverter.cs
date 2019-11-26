using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MBlogApp.Converters
{
	public class EmailTriggerConverter : IValueConverter
	{
		public object Convert(object value, Type targetType,
			object parameter, CultureInfo culture)
		{
			var email = (string)value;
			if (email == null || email.Length <= 4)
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
			throw new NotSupportedException();
		}
	}
}
