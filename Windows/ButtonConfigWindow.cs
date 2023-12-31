﻿using SoundBoardForms.Data;
using SoundBoardForms.Handlers;
using SoundBoardForms.Providers;
namespace SoundBoardForms.Windows
{
    public partial class ButtonConfigWindow : Form
    {
        public event EventHandler Saved = delegate { };
        public event EventHandler Deleted = delegate { };
        public SoundSettings? Settings { get; private set; }

        private readonly int i;

        public ButtonConfigWindow(SoundSettings? settings, int i, int x, int y)
        {
            this.i = i;
            InitializeComponent();
            settings ??= new SoundSettings();
            textFile.Text = settings?.Path;
            if (!string.IsNullOrEmpty(settings?.Path))
            {
                textText.PlaceholderText = settings?.Path.Split('\\')[^1];
            }
            textText.Text = settings?.Text;
            textPicture.Text = settings?.ImagePath;
            pictureBox1.BackColor = settings?.BackgroundColor ?? default;
            panelColor.BackColor = settings?.BackgroundColor ?? default;
            panelColor.ForeColor = settings?.TextColor ?? default;
            volumeSlider.Volume = settings?.Volume ?? default;
            numberStart.Value = settings?.Start ?? 0;
            numberEnd.Value = settings?.End ?? 0;
            if (string.IsNullOrEmpty(settings?.ImagePath))
                pictureBox1.ImageLocation = settings?.ImagePath;
            Text = $"Button {i + 1} settings (x: {x + 1}, y: {y + 1})";
        }

        private void volumeSlider_VolumeChanged(object sender, EventArgs e)
        {
            labelText.Text = volumeSlider.Volume.ToString();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Settings = SettingsProvider.Get(i) ?? SettingsProvider.Add(i);
            Settings.Path = textFile.Text;
            Settings.Text = textText.Text;
            Settings.ImagePath = textPicture.Text;
            Settings.BackgroundColor = panelColor.BackColor;
            Settings.TextColor = panelColor.ForeColor;
            Settings.Volume = volumeSlider.Volume;
            Settings.Start = (int)numberStart.Value;
            Settings.End = (int)numberEnd.Value;
            Saved.Invoke(this, e);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Deleted.Invoke(this, e);
            Close();
        }
        private void buttonFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = textFile.Text;
            openFileDialog.Filter = "Sound files|*.wav;*.mp3;*.wma;*.aac;*.mp4|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = string.IsNullOrEmpty(textPicture.Text);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFile.Text = openFileDialog.FileName;
                textText.PlaceholderText = openFileDialog.FileName.Split('\\')[^1];
            }
        }
        private void buttonPicture_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = textPicture.Text;
            openFileDialog.Filter = "Image files|*.bmp;*.gif;*.icon;*.jpg;*.jpeg;*.png;*.webp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = string.IsNullOrEmpty(textPicture.Text);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textPicture.Text = openFileDialog.FileName;
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                    pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new();
            colorDialog.Color = panelColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog.Color;
                panelColor.BackColor = colorDialog.Color;
            }
        }
        private void buttonTextColor_Click(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new();
            colorDialog.Color = panelColor.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.ForeColor = colorDialog.Color;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AudioPlayer.Play(textFile.Text, volumeSlider.Volume, (int)numberStart.Value, (int)numberEnd.Value);
        }
    }
}
