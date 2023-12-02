using SoundBoardForms.Components;
using SoundBoardForms.Providers;

namespace SoundBoardForms
{
    public partial class MainWindow : Form
    {
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
    }
}
