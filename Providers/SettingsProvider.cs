using Newtonsoft.Json;
using SoundBoardForms.Data;

namespace SoundBoardForms.Providers
{
    internal static class SettingsProvider
    {
        const string settingsPath = "settings.json";
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
            var serializer = new JsonSerializer();
            using var file = File.CreateText(settingsPath);
            serializer.Serialize(file, new SaveModel { G = GlobalSettings, M = Modes});
        }
        public static void Load()
        {
            if (!File.Exists(settingsPath)) return;
            var serializer = new JsonSerializer();
            using var file = File.OpenText(settingsPath);
            using var jsonReader = new JsonTextReader(file);
            var settings = serializer.Deserialize(jsonReader, typeof(SaveModel)) as SaveModel;
            GlobalSettings = settings?.G ?? new();
            Modes = settings?.M ?? [];
        }
        private class SaveModel
        {
            public GlobalSettings? G { get; set; }
            public Dictionary<int, Dictionary<int, SoundSettings>>? M { get; set; }
        }
    }
}