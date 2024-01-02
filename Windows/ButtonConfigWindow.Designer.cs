namespace SoundBoardForms.Windows
{
    partial class ButtonConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSound = new Panel();
            button1 = new Button();
            numberEnd = new NumericUpDown();
            numberStart = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textFile = new TextBox();
            buttonFile = new Button();
            volumeSlider = new NAudio.Gui.VolumeSlider();
            panelButtonProps = new Panel();
            panelColor = new Panel();
            buttonTextColor = new Button();
            labelTextColor = new Label();
            buttonColor = new Button();
            labelColor = new Label();
            panelText = new Panel();
            textText = new TextBox();
            labelText = new Label();
            panelImage = new Panel();
            pictureBox1 = new PictureBox();
            panelImageBrowser = new Panel();
            textPicture = new TextBox();
            buttonPicture = new Button();
            labelPicture = new Label();
            panelButtons = new Panel();
            buttonDelete = new Button();
            buttonCancel = new Button();
            buttonOk = new Button();
            panelSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberEnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberStart).BeginInit();
            panelButtonProps.SuspendLayout();
            panelColor.SuspendLayout();
            panelText.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelImageBrowser.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelSound
            // 
            panelSound.Controls.Add(button1);
            panelSound.Controls.Add(numberEnd);
            panelSound.Controls.Add(numberStart);
            panelSound.Controls.Add(label2);
            panelSound.Controls.Add(label1);
            panelSound.Controls.Add(textFile);
            panelSound.Controls.Add(buttonFile);
            panelSound.Controls.Add(volumeSlider);
            panelSound.Dock = DockStyle.Top;
            panelSound.Location = new Point(6, 6);
            panelSound.Margin = new Padding(3, 3, 3, 30);
            panelSound.Name = "panelSound";
            panelSound.Padding = new Padding(3);
            panelSound.Size = new Size(720, 100);
            panelSound.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(354, 35);
            button1.Name = "button1";
            button1.Size = new Size(70, 27);
            button1.TabIndex = 7;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numberEnd
            // 
            numberEnd.Location = new Point(258, 35);
            numberEnd.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numberEnd.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numberEnd.Name = "numberEnd";
            numberEnd.Size = new Size(90, 27);
            numberEnd.TabIndex = 6;
            // 
            // numberStart
            // 
            numberStart.Location = new Point(89, 35);
            numberStart.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numberStart.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numberStart.Name = "numberStart";
            numberStart.Size = new Size(90, 27);
            numberStart.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 37);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "End (ms)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Start (ms)";
            // 
            // textFile
            // 
            textFile.Dock = DockStyle.Fill;
            textFile.Location = new Point(3, 3);
            textFile.Name = "textFile";
            textFile.Size = new Size(620, 27);
            textFile.TabIndex = 0;
            // 
            // buttonFile
            // 
            buttonFile.Dock = DockStyle.Right;
            buttonFile.Location = new Point(623, 3);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(94, 74);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Browse";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // volumeSlider
            // 
            volumeSlider.Dock = DockStyle.Bottom;
            volumeSlider.Location = new Point(3, 77);
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(714, 20);
            volumeSlider.TabIndex = 2;
            volumeSlider.VolumeChanged += volumeSlider_VolumeChanged;
            // 
            // panelButtonProps
            // 
            panelButtonProps.Controls.Add(panelColor);
            panelButtonProps.Controls.Add(panelText);
            panelButtonProps.Controls.Add(panelImage);
            panelButtonProps.Dock = DockStyle.Top;
            panelButtonProps.Location = new Point(6, 106);
            panelButtonProps.Name = "panelButtonProps";
            panelButtonProps.Size = new Size(720, 177);
            panelButtonProps.TabIndex = 1;
            // 
            // panelColor
            // 
            panelColor.Controls.Add(buttonTextColor);
            panelColor.Controls.Add(labelTextColor);
            panelColor.Controls.Add(buttonColor);
            panelColor.Controls.Add(labelColor);
            panelColor.Dock = DockStyle.Fill;
            panelColor.Location = new Point(0, 48);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(560, 129);
            panelColor.TabIndex = 0;
            // 
            // buttonTextColor
            // 
            buttonTextColor.BackColor = SystemColors.ControlLight;
            buttonTextColor.ForeColor = Color.Black;
            buttonTextColor.Location = new Point(103, 40);
            buttonTextColor.Name = "buttonTextColor";
            buttonTextColor.Size = new Size(84, 28);
            buttonTextColor.TabIndex = 4;
            buttonTextColor.Text = "Choose";
            buttonTextColor.UseVisualStyleBackColor = false;
            buttonTextColor.Click += buttonTextColor_Click;
            // 
            // labelTextColor
            // 
            labelTextColor.AutoSize = true;
            labelTextColor.Location = new Point(3, 44);
            labelTextColor.Name = "labelTextColor";
            labelTextColor.Size = new Size(77, 20);
            labelTextColor.TabIndex = 3;
            labelTextColor.Text = "Text color:";
            // 
            // buttonColor
            // 
            buttonColor.BackColor = SystemColors.ControlLight;
            buttonColor.ForeColor = Color.Black;
            buttonColor.Location = new Point(103, 6);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(84, 28);
            buttonColor.TabIndex = 2;
            buttonColor.Text = "Choose";
            buttonColor.UseVisualStyleBackColor = false;
            buttonColor.Click += buttonColor_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(3, 10);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(94, 20);
            labelColor.TabIndex = 1;
            labelColor.Text = "Button color:";
            // 
            // panelText
            // 
            panelText.Controls.Add(textText);
            panelText.Controls.Add(labelText);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(0, 0);
            panelText.Name = "panelText";
            panelText.Size = new Size(560, 48);
            panelText.TabIndex = 1;
            // 
            // textText
            // 
            textText.Dock = DockStyle.Bottom;
            textText.Location = new Point(0, 21);
            textText.Name = "textText";
            textText.Size = new Size(560, 27);
            textText.TabIndex = 1;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(1, 1);
            labelText.Name = "labelText";
            labelText.Size = new Size(91, 20);
            labelText.TabIndex = 0;
            labelText.Text = "Custom text:";
            // 
            // panelImage
            // 
            panelImage.Controls.Add(pictureBox1);
            panelImage.Controls.Add(panelImageBrowser);
            panelImage.Controls.Add(labelPicture);
            panelImage.Dock = DockStyle.Right;
            panelImage.Location = new Point(560, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(160, 177);
            panelImage.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelImageBrowser
            // 
            panelImageBrowser.Controls.Add(textPicture);
            panelImageBrowser.Controls.Add(buttonPicture);
            panelImageBrowser.Dock = DockStyle.Top;
            panelImageBrowser.Location = new Point(0, 20);
            panelImageBrowser.Name = "panelImageBrowser";
            panelImageBrowser.Size = new Size(160, 28);
            panelImageBrowser.TabIndex = 1;
            // 
            // textPicture
            // 
            textPicture.Dock = DockStyle.Fill;
            textPicture.Location = new Point(0, 0);
            textPicture.Name = "textPicture";
            textPicture.Size = new Size(93, 27);
            textPicture.TabIndex = 0;
            // 
            // buttonPicture
            // 
            buttonPicture.Dock = DockStyle.Right;
            buttonPicture.Location = new Point(93, 0);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(67, 28);
            buttonPicture.TabIndex = 1;
            buttonPicture.Text = "Browse";
            buttonPicture.UseVisualStyleBackColor = true;
            buttonPicture.Click += buttonPicture_Click;
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Dock = DockStyle.Top;
            labelPicture.Location = new Point(0, 0);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(54, 20);
            labelPicture.TabIndex = 3;
            labelPicture.Text = "Image:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Controls.Add(buttonCancel);
            panelButtons.Controls.Add(buttonOk);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(6, 283);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(720, 35);
            panelButtons.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 9F);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(0, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(625, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOk.Location = new Point(525, 6);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // ButtonConfigWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 324);
            Controls.Add(panelButtons);
            Controls.Add(panelButtonProps);
            Controls.Add(panelSound);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ButtonConfigWindow";
            Padding = new Padding(6);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Sound Settings";
            TopMost = true;
            panelSound.ResumeLayout(false);
            panelSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberEnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberStart).EndInit();
            panelButtonProps.ResumeLayout(false);
            panelColor.ResumeLayout(false);
            panelColor.PerformLayout();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            panelImage.ResumeLayout(false);
            panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelImageBrowser.ResumeLayout(false);
            panelImageBrowser.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSound;
        private Button buttonFile;
        private TextBox textFile;
        private Panel panelButtonProps;
        private Panel panelButtons;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private Panel panelImage;
        private Panel panelText;
        private Panel panelColor;
        private PictureBox pictureBox1;
        private Label labelPicture;
        private Panel panelImageBrowser;
        private Button buttonPicture;
        private TextBox textPicture;
        private Button buttonCancel;
        private Button buttonOk;
        private Label labelText;
        private Button buttonTextColor;
        private Label labelTextColor;
        private Button buttonColor;
        private Label labelColor;
        private TextBox textText;
        private Button buttonDelete;
        private Label label2;
        private Label label1;
        private NumericUpDown numberEnd;
        private NumericUpDown numberStart;
        private Button button1;
    }
}