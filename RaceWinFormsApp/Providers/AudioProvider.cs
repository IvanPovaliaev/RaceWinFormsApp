using NAudio.Wave;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RaceWinFormsApp
{
    public static class AudioProvider
    {
        public async static Task PlayBGMAsync(string bgmDirectoryPath)
        {
            await Task.Run(() =>
            {
                var audioIndex = 0;
                var directoryInfo = new DirectoryInfo(bgmDirectoryPath);
                var audiosPaths = new List<string>();

                foreach (var file in directoryInfo.GetFiles("*.wav", SearchOption.TopDirectoryOnly))
                    audiosPaths.Add(file.FullName.ToString());

                audiosPaths = audiosPaths.Shuffle().ToList();

                StaticData.BGMPlayer = new WaveOutEvent();
                
                var audioFileReader = new AudioFileReader(audiosPaths[0]);

                StaticData.BGMPlayer.Init(audioFileReader);
                StaticData.BGMPlayer.Volume = SystemSettings.BGMVolume / 100f;

                StaticData.BGMPlayer.DeviceNumber = 0;

                StaticData.BGMPlayer.PlaybackStopped += (sender, e) =>
                {
                    audioFileReader.Dispose();

                    if (audioIndex + 1 == audiosPaths.Count)
                    {
                        audiosPaths = audiosPaths.Shuffle().ToList();
                        audioIndex = 0;
                    }
                    else audioIndex++;

                    audioFileReader = new AudioFileReader(audiosPaths[audioIndex]);
                    StaticData.BGMPlayer.Init(audioFileReader);
                    StaticData.BGMPlayer.Play();
                };

                StaticData.BGMPlayer.Play();
            });
        }
        public async static Task PlaySoundAsync(string audiofilePath)
        {
            await Task.Run(() =>
            {
                var audioFileReader = new AudioFileReader(audiofilePath);
                var waveChannel = new WaveChannel32(audioFileReader);
                waveChannel.Volume = SystemSettings.SoundsVolume / 100f;

                var player = new DirectSoundOut();
                player.Init(waveChannel);
                player.Play();
                player.PlaybackStopped += (sender, e) =>
                {
                    audioFileReader.Dispose();
                    waveChannel.Dispose();
                    player.Dispose();
                };
            });
        }
    }
}
