using SlotcarRennenM320.DataClasses;
using SlotcarRennenM320.Enums;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SlotcarRennenM320.Converters
{
    public class OrientationToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TrackNode node && parameter is string direction)
            {
                bool isVisible = direction switch
                {
                    "Top" => node.IngoingOrientation == Orientation.Top || node.OutgoingOrientation == Orientation.Top,
                    "Right" => node.IngoingOrientation == Orientation.Right || node.OutgoingOrientation == Orientation.Right,
                    "Bottom" => node.IngoingOrientation == Orientation.Bottom || node.OutgoingOrientation == Orientation.Bottom,
                    "Left" => node.IngoingOrientation == Orientation.Left || node.OutgoingOrientation == Orientation.Left,
                    _ => false
                };

                return isVisible ? Visibility.Visible : Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}