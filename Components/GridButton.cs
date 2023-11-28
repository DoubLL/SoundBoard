using SoundBoardForms.Data;

namespace SoundBoardForms.Components
{
    internal class GridButton : Button
    {
        private SoundSettings? Sound;

        public GridButton(SoundSettings? sound) : base()
        {
            Sound = sound;
            Dock = DockStyle.Fill;
            UpdateButton();
        }
        public GridButton() : base() { }
        private void UpdateButton()
        {
            Enabled = Sound != null;
            if (Sound == null) return;
            Text = Sound.Text;
        }
    }
}
