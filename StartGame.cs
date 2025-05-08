using OOP2_Exp6_Grp10.Pictures;
using System.Xml.Serialization;

namespace OOP2_Exp6_Grp10
{
    public partial class StartGame : Form
    {
        private GameSettings settings;

        public StartGame(GameSettings gameSettings)
        {
            InitializeComponent();
            settings = gameSettings;
        }
        private void playBtn_OnClick(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new GameSettings()
                {
                    SelectedCategory = "History",
                    SelectedDifficulty = "Easy",
                    SelectedImageType = "Hangman",
                    GameDuration = 60

                };
            }

            PlayForm gameform = new PlayForm(settings);
            gameform.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            this.Hide();
        }

        private void CategoryCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCmbBox.SelectedItem != null)
            {
                settings.SelectedCategory = CategoryCmbBox.SelectedItem.ToString();
            }
        }
    }
}
