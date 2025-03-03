using SlotcarRennenM320.Enums;
using System;
using System.Globalization;
using System.Windows.Data;

namespace SlotcarRennenM320.Converters
{
    public class OrientationToAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Orientation orientation)
            {
                return orientation switch
                {
                    Orientation.Right => 0,
                    Orientation.Bottom => 90,
                    Orientation.Left => 180,
                    Orientation.Top => 270,
                    _ => 0
                };
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
} 