using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public static class WinFormsProvider
    {
        public static void OpenChildForm(Form childForm)
        {
            StaticData.ActiveForm?.Close();

            StaticData.ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            StaticData.ChildFormPanel?.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// This method closes privious childForm and open new one to the childPanel in MainForm
        /// </summary>
        /// <param name="childForm">The childForm</param>
        /// <param name="useChildFormSize">If true the MainForm changes size to childForm size</param>
        /// <returns>The sum of the two integers.</returns>
        public static void OpenChildForm(Form childForm, bool useChildFormSize)
        {
            if (!useChildFormSize)
            {
                OpenChildForm(childForm);
                return;
            }
            StaticData.ActiveForm?.Close();
            StaticData.ActiveForm = childForm;

            StaticData.MainForm.ClientSize = childForm.ClientSize;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            StaticData.ChildFormPanel?.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public static void OpenDialogChildForm(Form childForm)
        {
            StaticData.ActiveForm.Enabled = false;
            StaticData.ActiveForm?.Hide();
            childForm.Dock = DockStyle.Fill;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            

            StaticData.ChildFormPanel?.Controls.Add(childForm);
            
            childForm.BringToFront();
            childForm.Show();

            childForm.FormClosed += (sender, e) =>
            {
                StaticData.ActiveForm?.Show();
                StaticData.ActiveForm.Enabled = true;
            };
        }

        public static List<MovableDottedRoadLane> InitializeRoadLanes(Form form)
        {
            new RoadLane(form, form.ClientSize.Width / 2, 16);
            var leftRoadLane = new MovableDottedRoadLane(form, 3 * form.ClientSize.Width / 4, 90, 16, 50);
            var rightRoadLane = new MovableDottedRoadLane(form, form.ClientSize.Width / 4, 90, 16, 50);
            var roadLanes = new List<MovableDottedRoadLane> { leftRoadLane, rightRoadLane };
            roadLanes.ForEach(lane => lane.Start());
            return roadLanes;
        }
        public static List<TowardCar> InitializeTowardCars(Form form, int carsCount)
        {
            var towardCars = new List<TowardCar>();
            for (int i = 0; i < carsCount; i++)
            {
                var car = new TowardCar(form);
                car.Start();
                towardCars.Add(car);
            }
            form.Paint += (sender, e) => _ = MoveAsideTowardCars(towardCars);
            return towardCars;
        }

        public static async Task MoveAsideTowardCars(IEnumerable<TowardCar> cars)
        {
            await Task.Run(() =>
            {
                var towardCars = cars.ToList();
                for (int i = 0; i < towardCars.Count; i++)
                {
                    for (int j = i + 1; j < towardCars.Count; j++)
                    {
                        TowardCar firstCar;
                        TowardCar secondCar;
                        if (towardCars[i].GetCentralPointF().Y < towardCars[j].GetCentralPointF().Y)
                        {
                            firstCar = towardCars[i];
                            secondCar = towardCars[j];
                        }
                        else
                        {
                            firstCar = towardCars[j];
                            secondCar = towardCars[i];
                        }

                        while (firstCar.GetBounds().IntersectsWith(secondCar.GetBounds()))
                        {
                            var offset = firstCar.GetBounds().X - secondCar.GetBounds().X;
                            firstCar.MoveAside(offset);
                        }
                    }
                }
            });
        }
    }
}
