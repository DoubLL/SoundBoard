using NAudio.Wave;
using SoundBoardForms.Providers;

namespace SoundBoardForms.Handlers
{
    internal static class AudioPlayer
    {
        private static DirectSoundOut? Output { get; set; }
        static AudioPlayer() { }
        public static void Play(string path, float volume, int start, int end)
        {
            if (Output != null)
            {
                Output.Stop();
            }
            Output = new DirectSoundOut(OutputProvider.CurrentDevice.Guid);
            var reader = new AudioFileReader(path);
            reader.Volume = volume * SettingsProvider.GlobalSettings.Volume / 100;
            reader.Position = Math.Min(((long)reader.WaveFormat.AverageBytesPerSecond) * start / 1000, reader.Length);
            Output.Init(reader);
            Output.PlaybackStopped += (sender, eventArgs) =>
            {
                Output = null;
            };
            Output.Play();
            if (end > -1)
                Task.Delay(TimeSpan.FromMilliseconds(end)).ContinueWith((task) =>
                {
                    Stop();
                });
        }
        public static void Stop()
        {
            if (Output == null) return;
            Output.Stop();
            Output = null;
        }
    }
}
