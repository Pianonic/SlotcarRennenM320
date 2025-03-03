using SlotcarRennenM320.Enums;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SlotcarRennenM320.Converters
{
    public class OrientationToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Orientation orientation)
            {
                return orientation != default(Orientation) ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
} 