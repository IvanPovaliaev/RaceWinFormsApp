using System;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public abstract class MovableCenterRectangle : CenterRectangle
    {
        protected System.Timers.Timer timer;
        protected float vx;
        protected float vy;

        public MovableCenterRectangle(Form form) : base(form)
        {
            InitializeTimer();
        }
        public void Start() => timer.Start();
        public void Pause() => timer.Stop();
        public void Stop() => timer.Dispose();
        public void SetSpeed(float vx, float vy)
        {
            this.vx = vx;
            this.vy = vy;
        }
        protected virtual void Move()
        {
            centerX += vx;
            centerY += vy;
        }
        protected abstract void Move_Tick(object? sender, EventArgs e);
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += Move_Tick;
        }
    }
}
