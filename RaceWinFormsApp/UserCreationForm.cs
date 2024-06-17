using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public partial class UserCreationForm : Form
    {
        public UserCreationForm()
        {
            InitializeComponent();
            playerNameTextBox.Text = StaticData.Player is null ? "NoName" : StaticData.Player.Name;
            if (StaticData.Player is null) returnButton.Text = "Exit";
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!ValidatePlayerName(out string message))
            {
                MessageBox.Show(message);
                return;
            }

            StaticData.Player = new Player(playerNameTextBox.Text);
            Properties.Settings.Default.LastPlayerName = StaticData.Player.Name;
            Properties.Settings.Default.Save();
            WinFormsProvider.OpenChildForm(new MenuForm());
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (StaticData.Player is null)
            {
                Application.Exit();
                return;
            }
            WinFormsProvider.OpenChildForm(new MenuForm());
        }

        private bool ValidatePlayerName(out string message)
        {
            var playerName = playerNameTextBox.Text;
            message = string.Empty;

            if (playerName.Length < 3 || playerName.Length > 16)
            {
                message = $"Player name must contain at least 3 characters and must not exceed 16 characters!";
                return false;
            }
            var invalidPattern = new Regex(@"[\[\].,;:!?\/""'(){}|`~@#$%^&*+=<>«»„“”’‘¿¡-]");
            if (invalidPattern.IsMatch(playerName))
            {
                message = $"The player name must not contain the following characters:\n{string.Join(" ", invalidPattern.ToString().ToCharArray())}";
                return false;
            }
            return true;
        }
    }
}
