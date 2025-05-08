using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Exp6_Grp10
{
    public partial class SettingsForm : Form
    {
        private GameSettings gameSettings; // Create an instance of GameSettings

        public SettingsForm()
        {
            InitializeComponent();
            gameSettings = new GameSettings(); // Initialize the instance

            // RadioButton'ların CheckedChanged olaylarını bağlayın
            HngManRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            SnwManRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            BreadRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            sixtySecRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            ninetySecRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            oneTwentyRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            EZRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            MidRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
            TuffRadioBtn.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HngManRadioBtn.Checked) { gameSettings.SelectedImageType = "Hangman"; }
            if (SnwManRadioBtn.Checked) { gameSettings.SelectedImageType = "Snowman"; }
            if (BreadRadioBtn.Checked) { gameSettings.SelectedImageType = "Bread"; }
            if (sixtySecRadioBtn.Checked) { gameSettings.GameDuration = 60; }
            if (ninetySecRadioBtn.Checked) { gameSettings.GameDuration = 90; }
            if (oneTwentyRadioBtn.Checked) { gameSettings.GameDuration = 120; }
            if (EZRadioBtn.Checked) { gameSettings.SelectedDifficulty = "Easy"; }
            if (MidRadioBtn.Checked) { gameSettings.SelectedDifficulty = "Medium"; }
            if (TuffRadioBtn.Checked) { gameSettings.SelectedDifficulty = "Hard"; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartGame start = new StartGame(gameSettings);
            start.Show();
            this.Hide();
        }
    }
    public class GameSettings
    {
        public string SelectedCategory { get; set; } = "History"; // Initialize with a default value  
        public string SelectedDifficulty { get; set; } = "Easy"; // Initialize with a default value  
        public int GameDuration { get; set; } = 60;
        public string SelectedImageType { get; set; } = "Hangman"; // Initialize with a default value  
        public void ResetToDefaults()
        {
            SelectedCategory = "History";
            SelectedDifficulty = "Easy";
            GameDuration = 60;
            SelectedImageType = "Hangman";
        }
    }
}
