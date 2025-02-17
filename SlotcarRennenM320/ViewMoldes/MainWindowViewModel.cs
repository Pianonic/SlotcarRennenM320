using System.ComponentModel;
using System.Windows.Controls;

namespace SlotcarRennenM320.ViewMoldes
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private Frame _contentFrame;

        public MainWindowViewModel()
        {
        }

        public void NavigateTo(object view)
        {
            _contentFrame.Navigate(view);
        }

        public void SetContentFrame(Frame contentFrame)
        {
            _contentFrame = contentFrame;
        }
    }
}
