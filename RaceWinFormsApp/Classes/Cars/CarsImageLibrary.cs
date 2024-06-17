using System.Collections.Generic;
using System.Drawing;

namespace RaceWinFormsApp
{
    public static class CarsImageLibrary
    {
        public static List<Image> GetAll()
        {
            var carsImages = new List<Image>
            {
                Properties.Resources.TowardsCarBlue,
                Properties.Resources.TowardsCarPurple,
                Properties.Resources.TowardsCarRed,
                Properties.Resources.TowardsCarWhite,
                Properties.Resources.TowardsCarTurquoise
            };
            return carsImages;
        }
    }
}
