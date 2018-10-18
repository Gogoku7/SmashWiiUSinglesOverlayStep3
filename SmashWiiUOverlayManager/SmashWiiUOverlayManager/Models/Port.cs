using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmashWiiUOverlayManager.Models
{
    public class Port : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Port(int id, string name, string path)
        {
            Id = id;
            Name = name;
            Path = path;
        }

        public static ObservableCollection<Port> InitiateSmashWiiUPortList()
        {
            return new ObservableCollection<Port>
            {
                new Port(0, "Player 1", @"..\\playerPorts\\playerPort1.png"),
                new Port(1, "Player 2", @"..\\playerPorts\\playerPort2.png"),
                new Port(2, "Player 3", @"..\\playerPorts\\playerPort3.png"),
                new Port(3, "Player 4", @"..\\playerPorts\\playerPort4.png"),
                new Port(4, "Player 5", @"..\\playerPorts\\playerPort5.png"),
                new Port(5, "Player 6", @"..\\playerPorts\\playerPort6.png"),
                new Port(6, "Player 7", @"..\\playerPorts\\playerPort7.png"),
                new Port(7, "Player 8", @"..\\playerPorts\\playerPort8.png")
            };
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
