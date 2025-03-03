using SlotcarRennenM320.Views;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace SlotcarRennenM320.ViewModels
{
    public class MainMenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand StartGameCommand { get; }
        public ICommand QuitCommand { get; }

        private readonly MainWindowViewModel _mainWindowViewModel;

        public MainMenuViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;

            StartGameCommand = new DelegateCommand(OnStartGame);
            QuitCommand = new DelegateCommand(OnQuit);
        }

        private void OnStartGame(object parameter)
        {
            _mainWindowViewModel.NavigateTo(new GameView(new GameViewModel()));
        }

        private void OnQuit(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
