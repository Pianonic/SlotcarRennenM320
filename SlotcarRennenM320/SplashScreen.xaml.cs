using SlotcarRennenM320.ViewModels.SlotcarRennenM320.ViewMoldes;
using System.Windows;

namespace SlotcarRennenM320
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
            DataContext = new SplashScreenViewModel();
        }
    }
}
