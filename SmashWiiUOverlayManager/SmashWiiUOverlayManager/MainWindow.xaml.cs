using SmashWiiUOverlayManager.FileManagers;
using SmashWiiUOverlayManager.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SmashWiiUOverlayManager
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private MainViewModel _mainViewModel;
        public MainViewModel MainViewModel
        {
            get
            {
                return _mainViewModel;
            }
            set
            {
                _mainViewModel = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainWindow()
        {
            InitializeComponent();
            InitiateDropDownLists();
            this.DataContext = this;
        }

        public void InitiateDropDownLists()
        {
            MainViewModel = new MainViewModel();
        }

        //EventHandlers
        private void Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                var cssFileReader = new CssFileReader();
                var cssFileDeleter = new CssFileDeleter();
                var cssFileTextReplacer = new CssFileTextReplacer();
                var cssFileWriter = new CssFileWriter();

                //Read
                var player1CharacterTemplateCss = cssFileReader.ReadPlayer1CharacterTemplateFile();
                var player2CharacterTemplateCss = cssFileReader.ReadPlayer2CharacterTemplateFile();

                var player1NameTextTemplateCss = cssFileReader.ReadPlayer1NameTextTemplateFile();
                var player2NameTextTemplateCss = cssFileReader.ReadPlayer2NameTextTemplateFile();

                var player1PortTemplateCss = cssFileReader.ReadPlayer1PortTemplateFile();
                var player2PortTemplateCss = cssFileReader.ReadPlayer2PortTemplateFile();

                var player1ScoreTextTemplateCss = cssFileReader.ReadPlayer1ScoreTextTemplateFile();
                var player2ScoreTextTemplateCss = cssFileReader.ReadPlayer2ScoreTextTemplateFile();

                var roundBoxTextTemplateCss = cssFileReader.ReadRoundBoxTextTemplateFile();

                //Replace
                var player1CharacterCss = cssFileTextReplacer.ReplacePlayer1CharacterTemplateFileText(player1CharacterTemplateCss, MainViewModel.Player1SelectedCharacter.Path);
                var player2CharacterCss = cssFileTextReplacer.ReplacePlayer1CharacterTemplateFileText(player2CharacterTemplateCss, MainViewModel.Player2SelectedCharacter.Path);

                var player1NameTextCss = cssFileTextReplacer.ReplacePlayer1NameTextTemplateFileText(player1NameTextTemplateCss, MainViewModel.Player1Sponsor, MainViewModel.Player1Name);
                var player2NameTextCss = cssFileTextReplacer.ReplacePlayer2NameTextTemplateFileText(player2NameTextTemplateCss, MainViewModel.Player2Sponsor, MainViewModel.Player2Name);

                var player1PortCss = cssFileTextReplacer.ReplacePlayer1PortTemplateFileText(player1PortTemplateCss, MainViewModel.Player1SelectedPort.Path);
                var player2PortCss = cssFileTextReplacer.ReplacePlayer2PortTemplateFileText(player2PortTemplateCss, MainViewModel.Player2SelectedPort.Path);

                var player1ScoreTextCss = cssFileTextReplacer.ReplacePlayer1ScoreTextTemplateFileText(player1ScoreTextTemplateCss, MainViewModel.Player1Score);
                var player2ScoreTextCss = cssFileTextReplacer.ReplacePlayer2ScoreTextTemplateFileText(player2ScoreTextTemplateCss, MainViewModel.Player2Score);

                var roundBoxTextCss = cssFileTextReplacer.ReplaceRoundBoxTextTemplateFileText(roundBoxTextTemplateCss, MainViewModel.Round);

                //Write
                cssFileWriter.WritePlayer1CharacterFile(player1CharacterCss);
                cssFileWriter.WritePlayer2CharacterFile(player2CharacterCss);

                cssFileWriter.WritePlayer1NameTextFile(player1NameTextCss);
                cssFileWriter.WritePlayer2NameTextFile(player2NameTextCss);

                cssFileWriter.WritePlayer1PortFile(player1PortCss);
                cssFileWriter.WritePlayer2PortFile(player2PortCss);

                cssFileWriter.WritePlayer1ScoreTextFile(player1ScoreTextCss);
                cssFileWriter.WritePlayer2ScoreTextFile(player2ScoreTextCss);

                cssFileWriter.WriteRoundBoxTextFile(roundBoxTextCss);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
