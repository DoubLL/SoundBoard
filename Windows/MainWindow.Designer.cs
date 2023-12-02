namespace SoundBoardForms
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            buttonGrid = new TableLayoutPanel();
            topPanel = new Panel();
            imageProfile = new PictureBox();
            inputProfile = new NumericUpDown();
            inputGridY = new NumericUpDown();
            iconGrid = new PictureBox();
            inputGridX = new NumericUpDown();
            iconOutput = new PictureBox();
            IconComport = new PictureBox();
            selectComport = new ComboBox();
            selectOutput = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputGridY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputGridX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconComport).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 1061);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(632, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // buttonGrid
            // 
            buttonGrid.ColumnCount = 1;
            buttonGrid.ColumnStyles.Add(new ColumnStyle());
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.Location = new Point(0, 38);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.RowCount = 1;
            buttonGrid.RowStyles.Add(new RowStyle());
            buttonGrid.Size = new Size(632, 1023);
            buttonGrid.TabIndex = 12;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(imageProfile);
            topPanel.Controls.Add(inputProfile);
            topPanel.Controls.Add(inputGridY);
            topPanel.Controls.Add(iconGrid);
            topPanel.Controls.Add(inputGridX);
            topPanel.Controls.Add(iconOutput);
            topPanel.Controls.Add(IconComport);
            topPanel.Controls.Add(selectComport);
            topPanel.Controls.Add(selectOutput);
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(label2);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(10, 0, 0, 0);
            topPanel.Size = new Size(632, 38);
            topPanel.TabIndex = 15;
            // 
            // imageProfile
            // 
            imageProfile.Image = Properties.Resources.MODE;
            imageProfile.Location = new Point(546, 5);
            imageProfile.Name = "imageProfile";
            imageProfile.Size = new Size(28, 28);
            imageProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            imageProfile.TabIndex = 24;
            imageProfile.TabStop = false;
            // 
            // inputProfile
            // 
            inputProfile.Location = new Point(577, 6);
            inputProfile.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            inputProfile.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputProfile.Name = "inputProfile";
            inputProfile.Size = new Size(45, 27);
            inputProfile.TabIndex = 23;
            inputProfile.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputProfile.ValueChanged += inputProfile_ValueChanged;
            // 
            // inputGridY
            // 
            inputGridY.Location = new Point(490, 6);
            inputGridY.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            inputGridY.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputGridY.Name = "inputGridY";
            inputGridY.Size = new Size(45, 27);
            inputGridY.TabIndex = 22;
            inputGridY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputGridY.ValueChanged += inputGridY_ValueChanged;
            // 
            // iconGrid
            // 
            iconGrid.Image = Properties.Resources.GRID;
            iconGrid.Location = new Point(387, 5);
            iconGrid.Name = "iconGrid";
            iconGrid.Size = new Size(28, 28);
            iconGrid.SizeMode = PictureBoxSizeMode.StretchImage;
            iconGrid.TabIndex = 20;
            iconGrid.TabStop = false;
            // 
            // inputGridX
            // 
            inputGridX.Location = new Point(430, 6);
            inputGridX.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            inputGridX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inputGridX.Name = "inputGridX";
            inputGridX.Size = new Size(45, 27);
            inputGridX.TabIndex = 19;
            inputGridX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            inputGridX.ValueChanged += inputGridX_ValueChanged;
            // 
            // iconOutput
            // 
            iconOutput.BackgroundImageLayout = ImageLayout.Zoom;
            iconOutput.Image = Properties.Resources.OUT;
            iconOutput.Location = new Point(198, 5);
            iconOutput.Name = "iconOutput";
            iconOutput.Size = new Size(28, 28);
            iconOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            iconOutput.TabIndex = 18;
            iconOutput.TabStop = false;
            // 
            // IconComport
            // 
            IconComport.BackgroundImageLayout = ImageLayout.Stretch;
            IconComport.Image = Properties.Resources.COM;
            IconComport.Location = new Point(10, 5);
            IconComport.Name = "IconComport";
            IconComport.Size = new Size(28, 28);
            IconComport.SizeMode = PictureBoxSizeMode.StretchImage;
            IconComport.TabIndex = 17;
            IconComport.TabStop = false;
            // 
            // selectComport
            // 
            selectComport.FormattingEnabled = true;
            selectComport.Location = new Point(40, 5);
            selectComport.Name = "selectComport";
            selectComport.Size = new Size(151, 28);
            selectComport.TabIndex = 16;
            // 
            // selectOutput
            // 
            selectOutput.FormattingEnabled = true;
            selectOutput.Location = new Point(228, 5);
            selectOutput.Name = "selectOutput";
            selectOutput.Size = new Size(151, 28);
            selectOutput.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 12);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 21;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 12);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 25;
            label2.Text = "y";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 1083);
            Controls.Add(buttonGrid);
            Controls.Add(topPanel);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(650, 400);
            Name = "MainWindow";
            Text = "Soundboard";
            Load += MainWindowLoad;
            SizeChanged += MainWindow_SizeChanged;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputGridY).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputGridX).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconComport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;

        private StatusStrip statusStrip1;

        private Panel topPanel;
        private PictureBox imageProfile;
        private NumericUpDown inputProfile;
        private NumericUpDown inputGridY;
        private PictureBox iconGrid;
        private NumericUpDown inputGridX;
        private PictureBox iconOutput;
        private PictureBox IconComport;
        private ComboBox selectComport;
        private ComboBox selectOutput;

        private TableLayoutPanel buttonGrid;
        private Label label2;
    }
}
