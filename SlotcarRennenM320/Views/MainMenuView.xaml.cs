using SlotcarRennenM320.ViewModels;
using System.Windows.Controls;

namespace SlotcarRennenM320.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenuView : Page
    {
        public MainMenuView(MainMenuViewModel mainMenuViewModel)
        {
            InitializeComponent();
            DataContext = mainMenuViewModel;
        }
    }
}
