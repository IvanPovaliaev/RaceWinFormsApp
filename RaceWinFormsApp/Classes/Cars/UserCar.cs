using System;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public class UserCar : Car
    {
        public override float Speed { get; set; }
        public UserCar(Form form) : base(form)
        {
            Image = Properties.Resources.MainCarYellow;
            width = 45;
            height = 100;

            IncreaseSpeed(2);

            centerX = form.ClientSize.Width / 2;
            centerY = DownSide();

            form.Paint += (sender, e) => e.Graphics.DrawImage(Image, GetBounds());
        }
        public void IncreaseSpeed(int speed) => Speed += speed;

        public void MoveLeft(float distance)
        {
            if (centerX - distance < LeftSide() - width / 2) centerX = RightSide() + width / 2;
            else centerX -= distance;
        }
        public void MoveRight(float distance)
        {
            if (centerX + distance > RightSide() + width / 2) centerX = LeftSide() - width / 2;
            else centerX += distance;
        }
        protected override void Move_Tick(object? sender, EventArgs e) { }
    }
}
