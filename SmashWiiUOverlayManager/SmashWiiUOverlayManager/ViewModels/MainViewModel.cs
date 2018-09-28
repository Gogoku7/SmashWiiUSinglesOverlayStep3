using SmashWiiUOverlayManager.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmashWiiUOverlayManager.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _player1Name;
        public string Player1Name
        {
            get
            {
                return _player1Name;
            }
            set
            {
                _player1Name = value;
                OnPropertyChanged();
            }
        }

        private string _player2Name;
        public string Player2Name
        {
            get
            {
                return _player2Name;
            }
            set
            {
                _player2Name = value;
                OnPropertyChanged();
            }
        }

        private string _player1Sponsor;
        public string Player1Sponsor
        {
            get
            {
                return _player1Sponsor;
            }
            set
            {
                _player1Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _player2Sponsor;
        public string Player2Sponsor
        {
            get
            {
                return _player2Sponsor;
            }
            set
            {
                _player2Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _player1Twitter;
        public string Player1Twitter
        {
            get
            {
                return _player1Twitter;
            }
            set
            {
                _player1Twitter = value;
                OnPropertyChanged();
            }
        }

        private string _player2Twitter;
        public string Player2Twitter
        {
            get
            {
                return _player2Twitter;
            }
            set
            {
                _player2Twitter = value;
                OnPropertyChanged();
            }
        }

        private string _player1Score;
        public string Player1Score
        {
            get
            {
                return _player1Score;
            }
            set
            {
                _player1Score = value;
                OnPropertyChanged();
            }
        }

        private string _player2Score;
        public string Player2Score
        {
            get
            {
                return _player2Score;
            }
            set
            {
                _player2Score = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Character> _characterList;
        public ObservableCollection<Character> CharacterList
        {
            get
            {
                return _characterList;
            }
            set
            {
                _characterList = value;
                OnPropertyChanged();
            }
        }

        private Character _player1SelectedCharacter;
        public Character Player1SelectedCharacter
        {
            get
            {
                return _player1SelectedCharacter;
            }
            set
            {
                _player1SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private Character _player2SelectedCharacter;
        public Character Player2SelectedCharacter
        {
            get
            {
                return _player2SelectedCharacter;
            }
            set
            {
                _player2SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Port> _portList;
        public ObservableCollection<Port> PortList
        {
            get
            {
                return _portList;
            }
            set
            {
                _portList = value;
                OnPropertyChanged();
            }
        }

        private Port _player1SelectedPort;
        public Port Player1SelectedPort
        {
            get
            {
                return _player1SelectedPort;
            }
            set
            {
                _player1SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private Port _player2SelectedPort;
        public Port Player2SelectedPort
        {
            get
            {
                return _player2SelectedPort;
            }
            set
            {
                _player2SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private string _tournamentName;
        public string TournamentName
        {
            get
            {
                return _tournamentName;
            }
            set
            {
                _tournamentName = value;
                OnPropertyChanged();
            }
        }

        private string _round;
        public string Round
        {
            get
            {
                return _round;
            }
            set
            {
                _round = value;
                OnPropertyChanged();
            }
        }

        private string _bestOf;
        public string BestOf
        {
            get
            {
                return _bestOf;
            }
            set
            {
                _bestOf = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainViewModel()
        {
            CharacterList = Character.InitiateSmashWiiUCharacterList();
            PortList = Port.InitiateSmashWiiUPortList();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
