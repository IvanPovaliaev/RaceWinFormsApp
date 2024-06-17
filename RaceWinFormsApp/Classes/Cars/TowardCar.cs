using System;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public class TowardCar : Car
    {
        public override float Speed {  get; set; }
        private static Random? random;
        
        public TowardCar(Form form) : base(form)
        {
            this.form = form;
            random = new Random();

            InitializeCarImage();
            width = 50;
            height = 100;                       

            InitializePosition();

            form.Paint += (sender, e) => e.Graphics.DrawImage(Image, GetBounds());            
        }

        public void MoveAside(int offset)
        {
            if (offset > 0) centerX += (width - offset);
            else centerX -= (width + offset);
                        
            if (centerX > RightSide()) centerX -= 2 * width;
            if (centerX < LeftSide()) centerX += 2 * width;
        }
        public void InitializePosition()
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = -height;
            Speed = (random.NextSingle() + 0.15f) * 3 + (StaticData.PlayerCar?.Speed ?? 0);
        }
        protected override void Move() => centerY += Speed + (StaticData.PlayerCar?.Speed ?? 0);
        protected override void Move_Tick(object? sender, EventArgs e)
        {
            Move();
            if (centerY - height > DownSide())
            {
                InitializePosition();
                InitializeCarImage();
            }
        }

        private void InitializeCarImage()
        {
            var carsImages = CarsImageLibrary.GetAll();
            Image = carsImages[new Random().Next(0, carsImages.Count)];
        }
    }
}
