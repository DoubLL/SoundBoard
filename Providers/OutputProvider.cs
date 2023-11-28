using NAudio.Wave;

namespace SoundBoardForms.Providers
{
    internal class OutputProvider
    {
        static OutputProvider()
        {
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                UnorderedDevices.Add(caps);
            }
            Devices = UnorderedDevices.ToList();
        }
        private static List<WaveOutCapabilities> UnorderedDevices { get; } = new();
        private static int index = 0;
        private static List<WaveOutCapabilities> Devices { get; } = new();

        public static WaveOutCapabilities CurrentDevice => Devices[index];
        public static IEnumerable<string> DeviceNames => Devices.Select(d => d.ProductName);
        public static void SetDevice(int i)
        {
            index = Math.Clamp(i, 0, Devices.Count - 1);
        }
        public static int DeviceIndex
        {
            get => UnorderedDevices.IndexOf(UnorderedDevices.Find(item => item.NameGuid == CurrentDevice.NameGuid));
        }
    }
}
