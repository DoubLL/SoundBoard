using System.IO.Ports;

namespace SoundBoardForms.Providers
{
    internal class BoardProvider
    {
        public static event EventHandler<int> ButtonPressed = delegate { };

        private static SerialPort? SerialPort;
        private static readonly Thread ReadThread = new Thread(Read);
        private static readonly Exception Exception = new InvalidOperationException("BoardProvider must be initialized");

        static BoardProvider() {
            AvailablePorts = SerialPort.GetPortNames().ToList();
        }
        public static List<string> AvailablePorts { get; private set; }
        public static void Init(string comPort)
        {
            SerialPort = new(comPort, 9600, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500,
                RtsEnable = true,
                DtrEnable = true
            };
            SerialPort.Open();
            ReadThread.Start();
        }
        public static void Close()
        {
            if (SerialPort == null)
                throw Exception;
            SerialPort.Close();
        }
        public static void Send(string message)
        {
            if (SerialPort == null)
                throw Exception;
            if (!string.IsNullOrEmpty(message))
                SerialPort.WriteLine(message);
        }
        private static void Read()
        {
            if (SerialPort == null)
                throw Exception;
            while (true)
            {
                try
                {
                    var message = SerialPort.ReadLine();
                    ButtonPressed.Invoke(typeof(BoardProvider), int.Parse(message));
                }
                catch (TimeoutException) { }
            }
        }
    }
}
