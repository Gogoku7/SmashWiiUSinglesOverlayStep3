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
                var cssFileTextReplacer = new CssFileTextReplacer();
                var cssFileWriter = new CssFileWriter();

                //Read
                var player1ScoreTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player1ScoreText.css");
                var player2ScoreTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player2ScoreText.css");

                var player1NameTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player1NameText.css");
                var player2NameTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player2NameText.css");

                var player1CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player1Character.css");
                var player2CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player2Character.css");

                var player1PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player1Port.css");
                var player2PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player2Port.css");

                var player1TwitterTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player1TwitterText.css");
                var player2TwitterTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\player2TwitterText.css");

                var roundBoxTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\roundBoxText.css");
                var tournamentBoxTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\tournamentBoxText.css");

                //Replace
                var player1ScoreTextCss = cssFileTextReplacer.ReplaceTemplateFileText(player1ScoreTextTemplateCss, !string.IsNullOrEmpty(MainViewModel.Player1Score) ? MainViewModel.Player1Score : "0");
                var player2ScoreTextCss = cssFileTextReplacer.ReplaceTemplateFileText(player2ScoreTextTemplateCss, !string.IsNullOrEmpty(MainViewModel.Player2Score) ? MainViewModel.Player2Score : "0");

                var player1NameTextCss = cssFileTextReplacer.ReplaceTemplateFileTextForTeam(player1NameTextTemplateCss, MainViewModel.Player1Sponsor, MainViewModel.Player1Name);
                var player2NameTextCss = cssFileTextReplacer.ReplaceTemplateFileTextForTeam(player2NameTextTemplateCss, MainViewModel.Player2Sponsor, MainViewModel.Player2Name);

                var player1CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(player1CharacterTemplateCss, MainViewModel.Player1SelectedCharacter != null ? MainViewModel.Player1SelectedCharacter.Path : @"..\\characterIcons\\random.png");
                var player2CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(player2CharacterTemplateCss, MainViewModel.Player2SelectedCharacter != null ? MainViewModel.Player2SelectedCharacter.Path : @"..\\characterIcons\\random.png");

                var player1PortCss = cssFileTextReplacer.ReplaceTemplateFileText(player1PortTemplateCss, MainViewModel.Player1SelectedPort != null ? MainViewModel.Player1SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");
                var player2PortCss = cssFileTextReplacer.ReplaceTemplateFileText(player2PortTemplateCss, MainViewModel.Player2SelectedPort != null ? MainViewModel.Player2SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");

                var player1TwitterTextCss = cssFileTextReplacer.ReplaceTemplateFileText(player1TwitterTextTemplateCss, MainViewModel.Player1Twitter);
                var player2TwitterTextCss = cssFileTextReplacer.ReplaceTemplateFileText(player2TwitterTextTemplateCss, MainViewModel.Player2Twitter);

                var roundBoxTextCss = cssFileTextReplacer.ReplaceTemplateFileText(roundBoxTextTemplateCss, $@"{MainViewModel.Round} / {MainViewModel.BestOf}");
                var tournamentBoxTextCss = cssFileTextReplacer.ReplaceTemplateFileText(tournamentBoxTextTemplateCss, MainViewModel.TournamentName);

                //Write
                cssFileWriter.WriteFile(@"Files\css\player1ScoreText.css", player1ScoreTextCss);
                cssFileWriter.WriteFile(@"Files\css\player2ScoreText.css", player2ScoreTextCss);

                cssFileWriter.WriteFile(@"Files\css\player1NameText.css", player1NameTextCss);
                cssFileWriter.WriteFile(@"Files\css\player2NameText.css", player2NameTextCss);

                cssFileWriter.WriteFile(@"Files\css\player1Character.css", player1CharacterCss);
                cssFileWriter.WriteFile(@"Files\css\player2Character.css", player2CharacterCss);

                cssFileWriter.WriteFile(@"Files\css\player1Port.css", player1PortCss);
                cssFileWriter.WriteFile(@"Files\css\player2Port.css", player2PortCss);

                cssFileWriter.WriteFile(@"Files\css\roundBoxText.css", roundBoxTextCss);
                cssFileWriter.WriteFile(@"Files\css\tournamentBoxText.css", tournamentBoxTextCss);
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
