using SoundBoardForms.Components;
using SoundBoardForms.Providers;
using System;
using System.Windows.Forms;

namespace SoundBoardForms
{
    public partial class MainWindow : Form
    {
        private bool loaded = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            selectComport.DataSource = ComProvider.AvailablePorts.ToList();
            AdjustSize(selectComport);
            selectOutput.DataSource = OutputProvider.DeviceNames.ToList();
            AdjustSize(selectOutput);
            inputGridX.Value = SettingsProvider.GlobalSettings.GridX;
            buttonGrid.ColumnCount = SettingsProvider.GlobalSettings.GridX;
            inputGridY.Value = SettingsProvider.GlobalSettings.GridY;
            buttonGrid.RowCount = SettingsProvider.GlobalSettings.GridY;
            Size = new Size(
                SettingsProvider.GlobalSettings.WindowX,
                SettingsProvider.GlobalSettings.WindowY);
            selectComport.SelectedIndex =
                Math.Max(selectComport.FindStringExact(SettingsProvider.GlobalSettings.ComPort), 0);
            selectOutput.SelectedIndex =
                Math.Max(selectOutput.FindStringExact(SettingsProvider.GlobalSettings.Output), 0);
            loaded = true;

            ComProvider.ButtonPressed += (sender, index) =>
            {
                try
                {
                    var button = buttonGrid.Controls[index] as GridButton;
                    if (button != null)
                    {
                        button.Play();
                    }
                }
                catch { }
            };
            ComProvider.StatusChanged += (sender, status) =>
            {
                if (status == ComStatus.Running)
                    IconComport.BackColor = Color.Green;
                else IconComport.BackColor = Color.Empty;
            };
        }
        private void RedrawGrid()
        {
            buttonGrid.Controls.Clear();
            for (int i = 0; i < buttonGrid.RowCount; i++)
                for (int j = 0; j < buttonGrid.ColumnCount; j++)
                {
                    var index = i * buttonGrid.ColumnCount + j;
                    buttonGrid.Controls.Add(new GridButton(index, i, j));
                }
        }
        private void AdjustSize(ComboBox box)
        {
            int maxWidth = 0;
            Label label1 = new Label();

            foreach (var obj in box.Items)
            {
                label1.Text = obj.ToString();
                if (label1.PreferredWidth > maxWidth)
                {
                    maxWidth = label1.PreferredWidth;
                }
            }
            label1.Dispose();
            box.DropDownWidth = maxWidth;
        }

        private void inputGridX_ValueChanged(object sender, EventArgs e)
        {
            SettingsProvider.GlobalSettings.GridX = (int)inputGridX.Value;
            buttonGrid.ColumnCount = (int)inputGridX.Value;
            buttonGrid.ColumnStyles.Clear();
            for (int i = 0; i < buttonGrid.ColumnCount; i++)
                buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / buttonGrid.ColumnCount));
            RedrawGrid();
        }
        private void inputGridY_ValueChanged(object sender, EventArgs e)
        {
            SettingsProvider.GlobalSettings.GridY = (int)inputGridY.Value;
            buttonGrid.RowCount = (int)inputGridY.Value;
            buttonGrid.RowStyles.Clear();
            for (int i = 0; i < buttonGrid.RowCount; i++)
                buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / buttonGrid.RowCount));
            RedrawGrid();
        }
        private void inputProfile_ValueChanged(object sender, EventArgs e)
        {
            SettingsProvider.GlobalSettings.Mode = (int)inputProfile.Value;
            inputGridX.Value = SettingsProvider.GlobalSettings.GridX;
            inputGridY.Value = SettingsProvider.GlobalSettings.GridY;
            Size = new Size(
                SettingsProvider.GlobalSettings.WindowX,
                SettingsProvider.GlobalSettings.WindowY);
            RedrawGrid();
        }
        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            SettingsProvider.GlobalSettings.WindowX = Size.Width;
            SettingsProvider.GlobalSettings.WindowY = Size.Height;
        }
        private void selectComport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                var name = (string)(selectComport.Items[selectComport.SelectedIndex] ?? "");
                SettingsProvider.GlobalSettings.ComPort = name;
                ComProvider.SetComPort(name);
            }
        }
        private void selectOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                var name = (string)(selectOutput.Items[selectOutput.SelectedIndex] ?? "");
                SettingsProvider.GlobalSettings.Output = name;
                OutputProvider.SetDevice(name);
            }
        }
        private void IconComport_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
                ComProvider.Connect();
            else ComProvider.RefreshComPorts();
        }
    }
}
