using System.Drawing;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public abstract class Car : MovableCenterRectangle
    {
        public abstract float Speed { get; set; }
        public Image? Image { get; protected set; }
        protected Car(Form form) : base(form) { }
    }
}
