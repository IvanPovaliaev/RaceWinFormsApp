using NAudio.Wave;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public static class StaticData
    {
        public static Form? ActiveForm;
        public static Form? DialogForm;
        public static Form? MainForm;
        public static Panel? ChildFormPanel;
        public static UserCar? PlayerCar;
        public static WaveOutEvent? BGMPlayer;
        public static Player? Player;
    }
}
