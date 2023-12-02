using Newtonsoft.Json;

namespace SoundBoardForms.Data
{
    internal class GlobalSettings
    {
        public int Volume { get; set; } = 100;
        public string ComPort { get; set; } = "";
        public string Output { get; set; } = "";
        public int GridX
        {
            get => Dimensions.GridX;
            set => Dimensions.GridX = value;
        }
        public int GridY
        {
            get => Dimensions.GridY;
            set => Dimensions.GridY = value;
        }
        public int WindowX
        {
            get => Dimensions.WindowX;
            set => Dimensions.WindowX = value;
        }
        public int WindowY
        {
            get => Dimensions.WindowY;
            set => Dimensions.WindowY = value;
        }
        public int Mode { get; set; } = 1;
        [JsonProperty]
        private readonly Dictionary<int, Dimension> AllDimensions = new();
        private Dimension Dimensions { get
            {
                AllDimensions.TryGetValue(Mode, out var dim);
                if (dim == null)
                {
                    dim = new Dimension();
                    AllDimensions.Add(Mode, dim);
                }
                return dim;
            }
        }

        private class Dimension
        {
            public int WindowX { get; set; } = 650;
            public int WindowY { get; set; } = 1130;
            public int GridX { get; set; } = 6;
            public int GridY { get; set; } = 10;
        }
    }
}
