using SlotcarRennenM320.Commands;
using SlotcarRennenM320.DataClasses;
using SlotcarRennenM320.Services;
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
            ReloadTrackCommand = new DelegateCommand(_ => ReloadTrack());
            LoadGameData();
        }

        private void LoadGameData()
        {
            Track = TrackLoader.LoadTrack("Assets/Tracks/default.xml");
        }

        private void ReloadTrack()
        {
            LoadGameData();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
