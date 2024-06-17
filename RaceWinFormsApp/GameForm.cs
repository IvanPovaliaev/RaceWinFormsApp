using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public partial class GameForm : Form
    {
        private List<MovableDottedRoadLane> roadLanes;        
        private List<TowardCar> towardCars;
        private const int towardCarsCount = 3;

        private List<Coin> coins;
        private const int coinsCount = 3;

        private UserCar userCar;       

        private Timer roadTimer;
        private Timer refreshTimer;
        private bool isPaused;

        private Player player;

        public GameForm()
        {
            InitializeComponent();
            player = StaticData.Player;
            KeyPreview = true;
        }

        //Данный метод убирает стандартное действие по переключению кнопок с помощью стрелок клавиатуры
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ActiveControl = null;
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Tab)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            roadLanes = WinFormsProvider.InitializeRoadLanes(this);

            StaticData.PlayerCar = new UserCar(this);
            userCar = StaticData.PlayerCar;

            InitializeCoins();
            towardCars = WinFormsProvider.InitializeTowardCars(this, towardCarsCount);

            InitializeTimers();

            ActiveControl = null;
            Focus();
        }
        private void InitializeCoins()
        {
            coins = new List<Coin>();
            for (int i = 0; i < coinsCount; i++)
            {
                var coin = new Coin(this);
                coin.Start();
                coins.Add(coin);
            }
        }
        private void InitializeTimers()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5;
            refreshTimer.Tick += (sender, e) =>
            {
                Invalidate();
                scoreLabel.Text = $"Score: {player.Score}"; //По аналогии с оригиналом. Хотелось реже инициализировать таймер
                coinsLabel.Text = $"Coins: {player.CoinsScore}";
            };
            refreshTimer.Start();

            roadTimer = new Timer();
            roadTimer.Interval = 20;
            roadTimer.Tick += (sender, e) =>
            {
                foreach (var coin in coins)
                {
                    if (userCar.GetBounds().IntersectsWith(coin.GetBounds()))
                    {
                        _ = AudioProvider.PlaySoundAsync(coin.CollectSoundPath);
                        coin.InitializePosition();
                        player.CoinsScore++;                        
                    }
                }
                foreach (var car in towardCars)
                {
                    if (userCar.GetBounds().IntersectsWith(car.GetBounds()) && !isPaused)
                    {
                        GameOver();
                        break;
                    }
                }
                player.Score+= (int)userCar.Speed*roadTimer.Interval / 20;
            };
            roadTimer.Start();
        }
        private void pauseButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenDialogChildForm(new PauseForm());
        private void GameForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Escape) WinFormsProvider.OpenDialogChildForm(new PauseForm());
            if (isPaused) return;

            if (userCar.Speed != 0)
            {
                if (e.KeyData == Keys.Right) userCar.MoveRight(20);
                if (e.KeyCode == Keys.Left) userCar.MoveLeft(20);
            }
            if (e.KeyData == Keys.Up && userCar.Speed < 21) userCar.IncreaseSpeed(1);
            if (e.KeyData == Keys.Down && userCar.Speed > 0) userCar.IncreaseSpeed(-1);
        }
        private void GameForm_EnabledChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
            Focus();            

            if (!isPaused)
            {
                isPaused = true;
                refreshTimer.Stop();
                roadTimer.Stop();
                roadLanes.ForEach(lane => lane.Pause());
                towardCars.ForEach(car => car.Pause());
                coins.ForEach(coins => coins.Pause());
                return;
            }

            isPaused = false;
            refreshTimer.Start();
            roadTimer.Start();
            roadLanes.ForEach(lane => lane.Start());
            towardCars.ForEach(car => car.Start());
            coins.ForEach(coins => coins.Start());
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roadTimer.Dispose();
            refreshTimer.Dispose();
            roadLanes.ForEach(lane => lane.Stop());
            towardCars.ForEach(car => car.Stop());
            coins.ForEach(coins => coins.Stop());
            StaticData.PlayerCar = null;
        }
        private void GameOver()
        {
            Enabled = false;
            if (player.CoinsScore >= 15)
            {
                var dialogResult = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    player.CoinsScore -= 15;
                    towardCars.ForEach(car => car.InitializePosition());
                    Enabled = true;
                    return;
                }
            }
            MessageBox.Show("Game Over!", "Приехали!");

            player.GameDate = DateTime.Now;
            PlayerStorage.Save(player);
            player.ResetResults();
            WinFormsProvider.OpenChildForm(new MenuForm(), true);
        }
    }
}
