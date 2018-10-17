using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmashWiiUOverlayManager.Models
{
    public class Character : INotifyPropertyChanged
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Character(int id, string name, string path)
        {
            Id = id;
            Name = name;
            Path = path;
        }

        public static ObservableCollection<Character> InitiateSmashWiiUCharacterList()
        {
            return new ObservableCollection<Character>
            {
                new Character(0, "Bayonetta", @"..\characterIcons\bayonetta.png"),
                new Character(1, "Bowser", @"..\characterIcons\Bowser.png"),
                new Character(2, "Bowser. Jr", @"..\characterIcons\bowserjr.png"),
                new Character(3, "Captain Falcon", @"..\characterIcons\captainfalcon.png"),
                new Character(4, "Charizard", @"..\characterIcons\charizard.png"),
                new Character(5, "Cloud", @"..\characterIcons\cloud.png"),
                new Character(6, "Corrin", @"..\characterIcons\corrin.png"),
                new Character(7, "Dark Pit", @"..\characterIcons\darkpit.png"),
                new Character(8, "Diddy Kong", @"..\characterIcons\diddykong.png"),
                new Character(9, "Donkey Kong", @"..\characterIcons\donkeykong.png"),
                new Character(10, "Dr. Mario", @"..\characterIcons\drmario.png"),
                new Character(11, "Duck Hunt", @"..\characterIcons\duckhunt.png"),
                new Character(12, "Falco", @"..\characterIcons\falco.png"),
                new Character(13, "Fox", @"..\characterIcons\fox.png"),
                new Character(14, "Ganondorf", @"..\characterIcons\ganondorf.png"),
                new Character(15, "Greninja", @"..\characterIcons\greninja.png"),
                new Character(16, "Ike", @"..\characterIcons\ike.png"),
                new Character(17, "Jigglypuff", @"..\characterIcons\jigglypuff.png"),
                new Character(18, "King Dedede", @"..\characterIcons\kingdedede.png"),
                new Character(19, "Kirby", @"..\characterIcons\kirby.png"),
                new Character(20, "Link", @"..\characterIcons\link.png"),
                new Character(21, "Little Mac", @"..\characterIcons\littlemac.png"),
                new Character(22, "Lucario", @"..\characterIcons\lucario.png"),
                new Character(23, "Lucas", @"..\characterIcons\lucas.png"),
                new Character(24, "Lucina", @"..\characterIcons\lucina.png"),
                new Character(25, "Luigi", @"..\characterIconsluigi.png"),
                new Character(26, "Mario", @"..\characterIcons\mario.png"),
                new Character(27, "Marth", @"..\characterIcons\marth.png"),
                new Character(28, "Mega Man", @"..\characterIcons\megaman.png"),
                new Character(29, "Meta Knight", @"..\characterIcons\metaknight.png"),
                new Character(30, "Mewtwo", @"..\characterIcons\mewtwo.png"),
                new Character(31, "Mii Brawler", @"..\characterIcons\miibrawler.png"),
                new Character(32, "Mii Gunner", @"..\characterIcons\miigunner.png"),
                new Character(33, "Mii Swordfighter", @"..\characterIcons\miiswordfighter.png"),
                new Character(34, "Mr. Game & Watch", @"..\characterIcons\mrgamewatch.png"),
                new Character(35, "Ness", @"..\characterIcons\ness.png"),
                new Character(36, "Olimar", @"..\characterIcons\olimar.png"),
                new Character(37, "Pac-Man", @"..\characterIcons\pacman.png"),
                new Character(38, "Palutena", @"..\characterIcons\palutena.png"),
                new Character(39, "Peach", @"..\characterIcons\peach.png"),
                new Character(40, "Pikachu", @"..\characterIcons\pikachu.png"),
                new Character(41, "Pit", @"..\characterIcons\pit.png"),
                new Character(42, "Random", @"..\characterIcons\random.png"),
                new Character(43, "R.O.B", @"..\characterIcons\rob.png"),
                new Character(44, "Robin", @"..\characterIcons\robin.png"),
                new Character(45, "Rosalina & Luma", @"..\characterIcons\rosalina.png"),
                new Character(46, "Roy", @"..\characterIcons\roy.png"),
                new Character(47, "Ryu", @"..\characterIcons\ryu.png"),
                new Character(48, "Samus", @"..\characterIcons\samus.png"),
                new Character(49, "Sheik", @"..\characterIcons\sheik.png"),
                new Character(50, "Shulk", @"..\characterIcons\shulk.png"),
                new Character(51, "Sonic", @"..\characterIcons\sonic.png"),
                new Character(52, "Toon Link", @"..\characterIcons\toonlink.png"),
                new Character(53, "Villager", @"..\characterIcons\villager.png"),
                new Character(54, "Wario", @"..\characterIcons\wario.png"),
                new Character(55, "Wii Fit Trainer", @"..\characterIcons\wiifittrainer.png"),
                new Character(56, "Yoshi", @"..\characterIcons\yoshi.png"),
                new Character(57, "Zelda", @"..\characterIcons\zelda.png"),
                new Character(58, "Zero Suit Samus", @"..\characterIcons\zerosuitsamus.png")
            };
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
