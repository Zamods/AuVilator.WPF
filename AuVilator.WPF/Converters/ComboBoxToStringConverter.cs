using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace AuVilator.WPF.Converters
{
    public class ComboBoxToStringConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                //var comboBoxItemValue = new ComboBoxItem() { Content = value.ToString() };
                var splittedStringValue = value.ToString().Split(' ');
                return $"{splittedStringValue[splittedStringValue.Length - 1]} {parameter}";
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /*var result = (String)value;
            var comboBoxItem = new ComboBoxItem()
            {
                Content = result.Split(' ')[0]
            };*/
            return value;
        }
    }
}
