using System;
using System.Windows;
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clever_Call_Center.Converter
{
    class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime _datetime = (DateTime)value;
            return _datetime.ToString("dd.MM.yyyy hh:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string _datetime = (string)value;
            return DateTime.Parse(_datetime);
        }
    }
}
