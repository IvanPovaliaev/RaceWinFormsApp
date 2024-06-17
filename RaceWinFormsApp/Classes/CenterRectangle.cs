using System.Drawing;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public abstract class CenterRectangle
    {        
        protected int width;
        protected int height;
        protected Form form;
        protected float centerX;
        protected float centerY;   

        public CenterRectangle(Form form)
        {
            this.form = form;
        }
        public int LeftSide() => width / 2;
        public int RightSide() => form.ClientSize.Width - width / 2;
        public int DownSide() => form.ClientSize.Height - height / 2;
        public Rectangle GetBounds()
        {
            return new Rectangle((int)centerX - width / 2, (int)centerY - height / 2, width, height);
        }
        public PointF GetCentralPointF() => new PointF(centerX, centerY);
    }
}
