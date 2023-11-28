namespace SoundBoardForms.Data
{
    internal class SoundSettings
    {
        public string Text { get; set; }
        public string Path { get; set; } = "";
        public int Start { get; set; } = 0;
        public int End { get; set; } = -1;
        public int Volume { get; set; } = 100;
        public Color Color { get; set; } = Color.Gainsboro;
        public string? ImagePath { get; set; }
        public SoundSettings() { }
    }
}
