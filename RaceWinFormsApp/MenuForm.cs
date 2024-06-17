using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public partial class MenuForm : Form
    {
        private List<MovableDottedRoadLane>? roadLanes;
        private Timer? refreshTimer;
        private List<TowardCar>? towardCars;
        private const int carsCount = 3;
        public MenuForm()
        {
            InitializeComponent();
            playerLabel.Text = $"Player: {StaticData.Player?.Name}";
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            roadLanes = WinFormsProvider.InitializeRoadLanes(this);
            towardCars = WinFormsProvider.InitializeTowardCars(this, carsCount);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5;
            refreshTimer.Tick += (sender, e) => Invalidate();
            refreshTimer.Start();
        }

        private void startButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new GameForm(), true);
        private void leaderBoardButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new LeaderBoardForm());
        private void settingsButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new SettingsForm());
        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();
        private void changePlayerButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new UserCreationForm());
        private void helpButton_Click(object sender, EventArgs e) => Help.ShowHelp(this, @"help.chm", HelpNavigator.TableOfContents);
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roadLanes?.ForEach(lane => lane.Stop());
            towardCars?.ForEach(car => car.Stop());
            refreshTimer?.Dispose();
        }
    }
}
