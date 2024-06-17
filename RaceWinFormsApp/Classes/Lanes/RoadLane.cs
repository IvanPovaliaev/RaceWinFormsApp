using System.Drawing;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public class RoadLane
    {
        protected int width { get; set; }
        protected Form form { get; set; }
        protected int positionX { get; set; }

        public RoadLane() { }
        public RoadLane(Form form, int x, int width)
        {
            this.form = form;
            positionX = x;
            this.width = width;

            InitializeLane();
        }

        protected virtual void InitializeLane()
        {
            var linePen = new Pen(Color.White, width);

            form.Paint += (sender, e) => e.Graphics.DrawLine(linePen, positionX, 0, positionX, form.Height);
        }
    }
}
