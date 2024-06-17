using System;
using System.Windows.Forms;

namespace RaceWinFormsApp
{
    public partial class SettingsForm : Form
    {
        private int initialSoundVolume;
        private int initialBGMVolume;
        public SettingsForm()
        {
            InitializeComponent();
            InitializeSoundVolumeSlider();
            InitializeBGMVolumeSlider();
            Invalidate();
        }
        private void InitializeSoundVolumeSlider()
        {
            initialSoundVolume = SystemSettings.SoundsVolume;
            soundSliderControl.Value = initialSoundVolume;
            soundSliderControl.ValueChanged += (sender, e) => SystemSettings.SoundsVolume = soundSliderControl.Value;
        }
        private void InitializeBGMVolumeSlider()
        {
            initialBGMVolume = SystemSettings.BGMVolume;
            bgmSliderControl.Value = initialBGMVolume;
            bgmSliderControl.ValueChanged += (sender, e) =>
            {
                SystemSettings.BGMVolume = bgmSliderControl.Value;
                StaticData.BGMPlayer.Volume = bgmSliderControl.Value / 100f;
            };
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SoundsVolume = SystemSettings.SoundsVolume;
            Properties.Settings.Default.BGMVolume = SystemSettings.BGMVolume;
            Properties.Settings.Default.Save();
            WinFormsProvider.OpenChildForm(new MenuForm());
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            SystemSettings.BGMVolume = initialBGMVolume;
            StaticData.BGMPlayer.Volume = initialBGMVolume / 100f;

            SystemSettings.SoundsVolume = initialSoundVolume;

            WinFormsProvider.OpenChildForm(new MenuForm());
        }

        private void soundSliderControl_MouseUp(object sender, MouseEventArgs e) => _ = AudioProvider.PlaySoundAsync(@".\Sounds\CoinCollectSound.wav");

    }
}
