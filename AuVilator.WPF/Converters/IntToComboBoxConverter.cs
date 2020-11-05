using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace AuVilator.WPF.Converters
{
    public class IntToComboBoxConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var intValue = (int)value;
            return new ComboBoxItem()
            {
                Content = intValue.ToString()
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                var comboBoxValue = (ComboBoxItem)value;
                return int.Parse(comboBoxValue.Content.ToString());
            }
            return value;
        }
    }
}
