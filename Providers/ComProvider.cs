using System.IO.Ports;
using System.Management;

namespace SoundBoardForms.Providers
{
    internal static class ComProvider
    {
        private static Dictionary<string, string> _availablePorts = [];
        private static SerialPort? SerialPort;
        private static readonly Thread ReadThread = new Thread(Read);
        private static string Selected = SettingsProvider.GlobalSettings.ComPort;
        private static ComStatus Status = ComStatus.Disconnected;

        public static IEnumerable<string> AvailablePorts = _availablePorts.Keys;
        public static event EventHandler<ComStatus> StatusChanged = delegate { };
        public static event EventHandler<int> ButtonPressed = delegate { };



        static ComProvider()
        {
            RefreshComPorts();
            StatusChanged.Invoke(typeof(ComProvider), ComStatus.Disconnected);
            ReadThread.IsBackground = true;
        }

        public static void RefreshComPorts()
        {
            _availablePorts.Clear();
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

        public static void SetComPort(string name)
        {
            Close();
            Selected = name;
        }
        public static void Connect()
        {
            try
            {
                SerialPort = new(_availablePorts.GetValueOrDefault(Selected), 9600, Parity.None, 8, StopBits.One)
                {
                    Handshake = Handshake.None,
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    RtsEnable = true,
                    DtrEnable = true
                };
                SerialPort.Open();
                Status = ComStatus.Running;
                ReadThread.Start();
                StatusChanged.Invoke(typeof(ComProvider), Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Close()
        {
            if (SerialPort == null)
                return;
            Status = ComStatus.Disconnected;
            SerialPort.Close();
            SerialPort = null;
            StatusChanged.Invoke(typeof(ComProvider), Status);
        }
        public static void Send(string message)
        {
            if (SerialPort == null)
                return;
            if (!string.IsNullOrEmpty(message))
                SerialPort.WriteLine(message);
        }
        private static void Read()
        {
            if (SerialPort == null)
                return;
            try
            {

                while (Status == ComStatus.Running)
                {
                    try
                    {
                        var message = SerialPort.ReadLine();
                        ButtonPressed.Invoke(typeof(ComProvider), int.Parse(message) - 1);
                    }
                    catch (TimeoutException) { }
                }
            }
            catch
            {
                Close();
            }
        }
    }

    public enum ComStatus
    {
        Running,
        Disconnected
    }
}
