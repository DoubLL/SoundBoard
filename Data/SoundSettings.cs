namespace SoundBoardForms.Data
{
    public class SoundSettings
    {
        public string? Text { get; set; }
        public string Path { get; set; } = "";
        public int Start { get; set; } = 0;
        public int End { get; set; } = -1;
        public float Volume { get; set; } = 1f;
        public Color BackgroundColor { get; set; } = Color.Gainsboro;
        public Color TextColor { get; set; } = Color.Black;
        public string? ImagePath { get; set; }
        public SoundSettings() { }
    }
}
