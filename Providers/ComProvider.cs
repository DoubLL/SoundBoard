using System.IO.Ports;
using System.Management;

namespace SoundBoardForms.Providers
{
    internal static class ComProvider
    {
        private static Dictionary<string, string> _availablePorts = new Dictionary<string, string>();
        public static IEnumerable<string> AvailablePorts = _availablePorts.Keys;
        static ComProvider ()
        {
            RefreshComPorts();
        }

        public static void RefreshComPorts()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                foreach (var portname in portnames)
                {
                   _availablePorts.Add(ports.FirstOrDefault(s => s != null && s.Contains(portname)) ?? "Unknown Device", portname);
                }
            }
        }
        public static string Current => _availablePorts[SettingsProvider.GlobalSettings.ComPort];
    }
}
