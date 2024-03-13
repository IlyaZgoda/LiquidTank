namespace LiquidTank
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            _pictureBox = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            _maxVolumeLabel = new Label();
            _currentVolumeValueLabel = new Label();
            drawTankButton = new Button();
            _maxVolumeValueLlabel = new Label();
            _currentVolumeLabel = new Label();
            panel3 = new Panel();
            _limitVolumeNumericUpDown = new NumericUpDown();
            _limitVolumeLabel = new Label();
            _valveStateComboBox = new ComboBox();
            _dripRateLabel = new Label();
            _valveModeComboBox = new ComboBox();
            _valveStateLabel = new Label();
            _dripRateNumericUpDown = new NumericUpDown();
            _valveModeLabel = new Label();
            _timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_limitVolumeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dripRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(_pictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 840);
            panel1.TabIndex = 0;
            // 
            // _pictureBox
            // 
            _pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _pictureBox.BackColor = Color.AliceBlue;
            _pictureBox.Location = new Point(0, 0);
            _pictureBox.Name = "_pictureBox";
            _pictureBox.Size = new Size(1323, 840);
            _pictureBox.TabIndex = 0;
            _pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 840);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateBlue;
            panel4.Controls.Add(_maxVolumeLabel);
            panel4.Controls.Add(_currentVolumeValueLabel);
            panel4.Controls.Add(drawTankButton);
            panel4.Controls.Add(_maxVolumeValueLlabel);
            panel4.Controls.Add(_currentVolumeLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 305);
            panel4.TabIndex = 15;
            // 
            // _maxVolumeLabel
            // 
            _maxVolumeLabel.AutoSize = true;
            _maxVolumeLabel.Font = new Font("Segoe UI", 14F);
            _maxVolumeLabel.ForeColor = Color.White;
            _maxVolumeLabel.Location = new Point(40, 39);
            _maxVolumeLabel.Name = "_maxVolumeLabel";
            _maxVolumeLabel.Size = new Size(216, 25);
            _maxVolumeLabel.TabIndex = 11;
            _maxVolumeLabel.Text = "Максимальный объем: ";
            // 
            // _currentVolumeValueLabel
            // 
            _currentVolumeValueLabel.AutoSize = true;
            _currentVolumeValueLabel.Font = new Font("Segoe UI", 14F);
            _currentVolumeValueLabel.ForeColor = Color.White;
            _currentVolumeValueLabel.Location = new Point(250, 100);
            _currentVolumeValueLabel.Name = "_currentVolumeValueLabel";
            _currentVolumeValueLabel.Size = new Size(22, 25);
            _currentVolumeValueLabel.TabIndex = 14;
            _currentVolumeValueLabel.Text = "0";
            // 
            // drawTankButton
            // 
            drawTankButton.Location = new Point(118, 179);
            drawTankButton.Name = "drawTankButton";
            drawTankButton.Size = new Size(80, 24);
            drawTankButton.TabIndex = 2;
            drawTankButton.Text = "Отобразить";
            drawTankButton.UseVisualStyleBackColor = true;
            drawTankButton.Click += button1_Click;
            // 
            // _maxVolumeValueLlabel
            // 
            _maxVolumeValueLlabel.AutoSize = true;
            _maxVolumeValueLlabel.Font = new Font("Segoe UI", 14F);
            _maxVolumeValueLlabel.ForeColor = Color.White;
            _maxVolumeValueLlabel.Location = new Point(250, 39);
            _maxVolumeValueLlabel.Name = "_maxVolumeValueLlabel";
            _maxVolumeValueLlabel.Size = new Size(22, 25);
            _maxVolumeValueLlabel.TabIndex = 13;
            _maxVolumeValueLlabel.Text = "0";
            // 
            // _currentVolumeLabel
            // 
            _currentVolumeLabel.AutoSize = true;
            _currentVolumeLabel.Font = new Font("Segoe UI", 14F);
            _currentVolumeLabel.ForeColor = Color.White;
            _currentVolumeLabel.Location = new Point(40, 100);
            _currentVolumeLabel.Name = "_currentVolumeLabel";
            _currentVolumeLabel.Size = new Size(158, 25);
            _currentVolumeLabel.TabIndex = 12;
            _currentVolumeLabel.Text = "Текущий объем: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateBlue;
            panel3.Controls.Add(_limitVolumeNumericUpDown);
            panel3.Controls.Add(_limitVolumeLabel);
            panel3.Controls.Add(_valveStateComboBox);
            panel3.Controls.Add(_dripRateLabel);
            panel3.Controls.Add(_valveModeComboBox);
            panel3.Controls.Add(_valveStateLabel);
            panel3.Controls.Add(_dripRateNumericUpDown);
            panel3.Controls.Add(_valveModeLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 301);
            panel3.TabIndex = 9;
            // 
            // _limitVolumeNumericUpDown
            // 
            _limitVolumeNumericUpDown.BackColor = SystemColors.Window;
            _limitVolumeNumericUpDown.Font = new Font("Segoe UI", 10F);
            _limitVolumeNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            _limitVolumeNumericUpDown.Location = new Point(183, 254);
            _limitVolumeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _limitVolumeNumericUpDown.Name = "_limitVolumeNumericUpDown";
            _limitVolumeNumericUpDown.Size = new Size(120, 25);
            _limitVolumeNumericUpDown.TabIndex = 10;
            // 
            // _limitVolumeLabel
            // 
            _limitVolumeLabel.AutoSize = true;
            _limitVolumeLabel.Font = new Font("Segoe UI", 14F);
            _limitVolumeLabel.ForeColor = Color.White;
            _limitVolumeLabel.Location = new Point(40, 254);
            _limitVolumeLabel.Name = "_limitVolumeLabel";
            _limitVolumeLabel.Size = new Size(107, 25);
            _limitVolumeLabel.TabIndex = 9;
            _limitVolumeLabel.Text = "До объема";
            // 
            // _valveStateComboBox
            // 
            _valveStateComboBox.AccessibleDescription = "";
            _valveStateComboBox.BackColor = SystemColors.Window;
            _valveStateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _valveStateComboBox.Font = new Font("Segoe UI", 10F);
            _valveStateComboBox.ForeColor = SystemColors.InfoText;
            _valveStateComboBox.FormattingEnabled = true;
            _valveStateComboBox.Items.AddRange(new object[] { "Закрыт", "Открыт" });
            _valveStateComboBox.Location = new Point(182, 40);
            _valveStateComboBox.Name = "_valveStateComboBox";
            _valveStateComboBox.Size = new Size(121, 25);
            _valveStateComboBox.TabIndex = 4;
            _valveStateComboBox.SelectedIndexChanged += ValveStateComboBox_SelectedIndexChanged;
            // 
            // _dripRateLabel
            // 
            _dripRateLabel.AutoSize = true;
            _dripRateLabel.Font = new Font("Segoe UI", 14F);
            _dripRateLabel.ForeColor = Color.White;
            _dripRateLabel.Location = new Point(40, 183);
            _dripRateLabel.Name = "_dripRateLabel";
            _dripRateLabel.Size = new Size(93, 25);
            _dripRateLabel.TabIndex = 8;
            _dripRateLabel.Text = "Скорость";
            // 
            // _valveModeComboBox
            // 
            _valveModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _valveModeComboBox.Font = new Font("Segoe UI", 10F);
            _valveModeComboBox.FormattingEnabled = true;
            _valveModeComboBox.Location = new Point(182, 114);
            _valveModeComboBox.Name = "_valveModeComboBox";
            _valveModeComboBox.Size = new Size(121, 25);
            _valveModeComboBox.TabIndex = 3;
            _valveModeComboBox.Tag = "";
            _valveModeComboBox.SelectedIndexChanged += ValveModeComboBox_SelectedIndexChanged;
            // 
            // _valveStateLabel
            // 
            _valveStateLabel.AutoSize = true;
            _valveStateLabel.Font = new Font("Segoe UI", 14F);
            _valveStateLabel.ForeColor = Color.White;
            _valveStateLabel.Location = new Point(40, 38);
            _valveStateLabel.Name = "_valveStateLabel";
            _valveStateLabel.Size = new Size(105, 25);
            _valveStateLabel.TabIndex = 7;
            _valveStateLabel.Text = "Состояние";
            // 
            // _dripRateNumericUpDown
            // 
            _dripRateNumericUpDown.BackColor = SystemColors.Window;
            _dripRateNumericUpDown.Font = new Font("Segoe UI", 10F);
            _dripRateNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            _dripRateNumericUpDown.Location = new Point(182, 183);
            _dripRateNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _dripRateNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _dripRateNumericUpDown.Name = "_dripRateNumericUpDown";
            _dripRateNumericUpDown.Size = new Size(120, 25);
            _dripRateNumericUpDown.TabIndex = 5;
            _dripRateNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            _dripRateNumericUpDown.ValueChanged += DripRateNumericUpDown_ValueChanged;
            // 
            // _valveModeLabel
            // 
            _valveModeLabel.AutoSize = true;
            _valveModeLabel.Font = new Font("Segoe UI", 14F);
            _valveModeLabel.ForeColor = Color.White;
            _valveModeLabel.Location = new Point(40, 112);
            _valveModeLabel.Name = "_valveModeLabel";
            _valveModeLabel.Size = new Size(71, 25);
            _valveModeLabel.TabIndex = 6;
            _valveModeLabel.Text = "Режим";
            // 
            // _timer
            // 
            _timer.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 840);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Liquid tank";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_limitVolumeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dripRateNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox _pictureBox;
        private Panel panel2;
        private Button drawTankButton;
        private ComboBox _valveModeComboBox;
        private Label _valveModeLabel;
        private NumericUpDown _dripRateNumericUpDown;
        private ComboBox _valveStateComboBox;
        private Label _dripRateLabel;
        private Label _valveStateLabel;
        private Panel panel3;
        private System.Windows.Forms.Timer _timer;
        private NumericUpDown _limitVolumeNumericUpDown;
        private Label _limitVolumeLabel;
        private Label _currentVolumeLabel;
        private Label _maxVolumeLabel;
        private Label _maxVolumeValueLlabel;
        private Label _currentVolumeValueLabel;
        private Panel panel4;
    }
}
