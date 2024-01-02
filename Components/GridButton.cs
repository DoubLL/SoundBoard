using SoundBoardForms.Data;
using SoundBoardForms.Handlers;
using SoundBoardForms.Providers;
using SoundBoardForms.Windows;

namespace SoundBoardForms.Components
{
    internal class GridButton : Button
    {
        private SoundSettings? Settings;
        private readonly int i;
        private readonly int x;
        private readonly int y;

        public GridButton(int index, int x, int y) : base()
        {
            Settings = SettingsProvider.Get(index);
            i = index;
            this.x = x;
            this.y = y;
            Dock = DockStyle.Fill;
            MouseUp += OnMouseUp;
            UpdateButton();
            BackgroundImageLayout = ImageLayout.Zoom;
        }
        public void Play()
        {
            if (Settings == null) return;
            AudioPlayer.Play(Settings.Path, Settings.Volume, Settings.Start, Settings.End);
        }

        public void OnMouseUp(object sender, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button == MouseButtons.Left)
            {
                Play();
            }
            else
            {
                ButtonConfigWindow window = new ButtonConfigWindow(Settings, i, x, y);
                window.Saved += (sender, eventArgs) =>
                {
                    Settings = window.Settings;
                    UpdateButton();
                };
                window.Deleted += (sender, eventArgs) =>
                {
                    SettingsProvider.Delete(i);
                    Settings = null;
                    UpdateButton();
                };
                window.ShowDialog();
            }
        }

        private void UpdateButton()
        {
            Text = string.IsNullOrEmpty(Settings?.Text)
                ? Settings?.Path?.Split('\\')[^1] : Settings.Text;
            BackColor = Settings?.BackgroundColor ?? default;
            ForeColor = Settings?.TextColor ?? default;
            if (!string.IsNullOrEmpty(Settings?.ImagePath))
                BackgroundImage = Image.FromFile(Settings.ImagePath);
            else BackgroundImage = null;
        }
    }
}
