using NAudio.Wave;

namespace SoundBoardForms.Providers
{
    internal class OutputProvider
    {
        static OutputProvider()
        {
            Devices = DirectSoundOut.Devices.OrderBy(_ => _.Description).ToList();
            index = Math.Max(Devices.FindIndex(item => item.Description == SettingsProvider.GlobalSettings.Output), 0);
        }
        private static int index = 0;
        private static List<DirectSoundDeviceInfo> Devices { get; } = [];
        public static int CurrentIndex => index;
        public static DirectSoundDeviceInfo CurrentDevice => Devices[index];
        public static IEnumerable<string> DeviceNames => Devices.Select(d => d.Description);
        public static void SetDevice(string name)
        {
            index = Math.Max(Devices.FindIndex(item => item.Description == name),0);
        }

    }
}
