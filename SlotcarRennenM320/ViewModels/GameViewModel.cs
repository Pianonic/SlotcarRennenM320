using SlotcarRennenM320.DataClasses;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace SlotcarRennenM320.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<ObservableCollection<TrackNode>> _track;
        public ObservableCollection<ObservableCollection<TrackNode>> Track
        {
            get => _track;
            set
            {
                _track = value;
                OnPropertyChanged(nameof(Track));
            }
        }

        public ICommand ReloadTrackCommand { get; }

        public GameViewModel()
        {
            ReloadTrackCommand = new DelegateCommand(ReloadTrack);
            LoadGameData();
        }

        private void LoadGameData()
        {

        }
    }
}
