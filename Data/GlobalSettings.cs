namespace SoundBoardForms.Data
{
    internal class GlobalSettings
    {
        public int Volume { get; set; } = 20;
        public int ComPort { get; set; } = 0;
        public int Output { get; set; } = 0;
        public int GridX
        {
            get
            {
                if (!Dimentions.TryGetValue(Mode, out var t))
                {
                    t = new(defaultX, defaultY);
                    Dimentions.Add(Mode, t);
                }
                return t.Item1;
            }
            set
            {
                if (Dimentions.TryGetValue(Mode, out var t))
                {
                    Dimentions[Mode] = new Tuple<int, int>(value, t.Item2);
                }
                else
                    Dimentions.Add(Mode, new Tuple<int, int>(value, defaultY));
            }
        }
        public int GridY
        {
            get
            {
                if (!Dimentions.TryGetValue(Mode, out var t))
                {
                    t = new(defaultX, defaultY);
                    Dimentions.Add(Mode, t);
                }
                return t.Item2;
            }
            set
            {
                if (Dimentions.TryGetValue(Mode, out var t))
                {
                    Dimentions[Mode] = new Tuple<int, int>(t.Item1, value);
                }
                else
                    Dimentions.Add(Mode, new Tuple<int, int>(defaultX, value));
            }
        }
        public int Mode { get; set; } = 1;

        private readonly Dictionary<int, Tuple<int, int>> Dimentions = [];
        private const int defaultX = 6;
        private const int defaultY = 10;
    }
}
