﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace DietAndFitness.Converters
{
    public class StringToNullableDouble : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            double myValue = (double)value;
            return myValue.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string stringValue = value as string;
            if (string.IsNullOrWhiteSpace(stringValue))
                return null;
            if (Double.TryParse(stringValue, out double myValue))
                return myValue;
            else
                return 0;
        }
    }
}
