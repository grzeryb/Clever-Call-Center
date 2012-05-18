using System;
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clever_Call_Center.Converter
{
    class ActiveConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool _active = (bool)value;
            if (_active == true)
            {
                return "Tak";
            }
            else return "Nie";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string _active = (string)value;
            if (_active == "Tak")
            {
                return true;
            }
            else return false;
        }
    }
}
