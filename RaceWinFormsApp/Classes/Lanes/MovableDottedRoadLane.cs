using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public class MovableDottedRoadLane : RoadLane
    {
        private int height { get; set; }
        private int offset { get; set; }
        private System.Timers.Timer timer { get; set; }
        private float vy;
        private float startY { get; set; }
        private float endY { get; set; }

        public MovableDottedRoadLane(Form form, int x, int height, int width, int offset) : base()
        {
            this.form = form;
            this.width = width;
            this.height = height;
            this.offset = offset;
            positionX = x;
            vy = 5;

            InitializeLane();
            InitializeTimer();
        }

        protected override void InitializeLane()
        {
            startY = -1.5f * height - offset;
            var dashCount = (int)(form.ClientSize.Height - 0.5f * height)/(height + offset) + 1;
            endY = dashCount * (height + offset);

            var linePen = new Pen(Color.White, width);
            linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            linePen.DashPattern = [(float)height / width, (float)offset / width];

            form.Paint += (sender, e) => e.Graphics.DrawLine(linePen, positionX, startY, positionX, endY);
        }
        public void Start() => timer.Start();
        public void Pause() => timer.Stop();
        public void Stop() => timer.Dispose();
        public void AddDissapearEvent(EventHandler dissapearEvent) => timer.Disposed += dissapearEvent;
        private void Move()
        {
            startY += StaticData.PlayerCar?.Speed ?? vy;
            endY += StaticData.PlayerCar?.Speed ?? vy;
        }
        private void Move_Tick(object? sender, EventArgs e)
        {
            Move();
            if (startY >= -height / 2)
            {
                startY -= (height + offset);
                endY -= (height + offset);
            }
        }
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += Move_Tick;
        }
    }
}
