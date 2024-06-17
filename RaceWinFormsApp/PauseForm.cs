using System;
using System.Windows.Forms;

namespace RaceWinFormsApp
{

    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
        }

        private void rusumeButton_Click(object sender, EventArgs e) => Close();
        private void exitButton_Click(object sender, EventArgs e)
        {
            WinFormsProvider.OpenChildForm(new MenuForm(), true);
            Close();
        }
    }
}
