using SlotcarRennenM320.ViewModels;
using System.Windows.Controls;

namespace SlotcarRennenM320.Views
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Page
    {
        public GameView(GameViewModel gameViewModel)
        {
            InitializeComponent();
            DataContext = gameViewModel;
        }
    }
}
