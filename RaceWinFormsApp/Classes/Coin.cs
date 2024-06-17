using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public class Coin : MovableCenterRectangle
    {
        private Image image { get; set; }
        public string CollectSoundPath = @".\Sounds\CoinCollectSound.wav";
        public Coin(Form form) : base(form)
        {
            width = 35;
            height = 35;
            InitializePosition();

            image = Properties.Resources.Coin;

            form.Paint += (sender, e) => e.Graphics.DrawImage(image, GetBounds());
        }
        public void InitializePosition()
        {
            centerX = new Random().Next(LeftSide(), RightSide());
            centerY = new Random().Next(-5 * height, 0);
        }
        protected override void Move()
        {
            centerY += (StaticData.PlayerCar?.Speed ?? 0);
            if (centerY - height > DownSide()) InitializePosition();
        }
        protected override void Move_Tick(object? sender, EventArgs e) => Move();
           
    }
}
