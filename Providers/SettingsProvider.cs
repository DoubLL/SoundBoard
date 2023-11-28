using SoundBoardForms.Data;

namespace SoundBoardForms.Providers
{
    internal static class SettingsProvider
    {
        private static Dictionary<int, Dictionary<int, SoundSettings>> Modes { get; set; } = new();
        private static Dictionary<int, SoundSettings> Buttons {  get
            {
                if (!Modes.TryGetValue(GlobalSettings.Mode, out var dict))
                {
                    dict = new Dictionary<int, SoundSettings>();
                    Modes.Add(GlobalSettings.Mode, dict);
                }
                return dict;
            } }
        public static GlobalSettings GlobalSettings { get; private set; } = new();

        static SettingsProvider()
        {
            Load();
        }

        public static SoundSettings? Get(int id)
        {
            if (Buttons.TryGetValue(id, out var value)) return value;
            return null;
        }
        public static SoundSettings Add(int id)
        {
            if (Buttons.ContainsKey(id)) throw new ArgumentException("Button already exists!");
            var button = new SoundSettings();
            Buttons.Add(id, button);
            return button;
        }
        public static void Delete(int id)
        {
            if (!Buttons.ContainsKey(id)) throw new ArgumentOutOfRangeException(nameof(id));
            Buttons.Remove(id);
        }
        public static void Save()
        {

        }
        public static void Load()
        {
            Buttons.Clear();
            Buttons.Add(0, new SoundSettings
            {
                Text = "Button 1",
                Path = "",
                Volume = 50,
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                ImagePath = ""
            });
            Buttons.Add(1, new SoundSettings
            {
                Text = "Button 2",
                Path = "",
                Volume = 25,
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                ImagePath = "D:\\Daten\\Pictures\\emoji.png"
            });
            Buttons.Add(2, new SoundSettings
            {
                Text = "",
                Path = "",
                Volume = 100,
                BackgroundColor = Color.White,
                TextColor = Color.Black,
                ImagePath = ""
            });
            Buttons.Add(10, new SoundSettings
            {
                Text = "Button 4",
                Path = "",
                Volume = 100,
                BackgroundColor = Color.DarkRed,
                TextColor = Color.White,
                ImagePath = ""
            });
            
        }
    }
}
