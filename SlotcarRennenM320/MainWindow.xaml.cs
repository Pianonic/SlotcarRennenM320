using SlotcarRennenM320.ViewModels;
using SlotcarRennenM320.Views;
using System.Windows;

namespace SlotcarRennenM320
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.SetContentFrame(ContentFrame);
            mainWindowViewModel.NavigateTo(new MainMenuView(new MainMenuViewModel(mainWindowViewModel)));
        }
    }
}