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
            panel3 = new Panel();
            _valveStateComboBox = new ComboBox();
            _dripRateLabel = new Label();
            _valveModeComboBox = new ComboBox();
            _valveStateLabel = new Label();
            _dripRateNumericUpDown = new NumericUpDown();
            _valveModeLabel = new Label();
            drawTankButton = new Button();
            _timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dripRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(_pictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 779);
            panel1.TabIndex = 0;
            // 
            // _pictureBox
            // 
            _pictureBox.BackColor = Color.AliceBlue;
            _pictureBox.Dock = DockStyle.Fill;
            _pictureBox.Location = new Point(0, 0);
            _pictureBox.Name = "_pictureBox";
            _pictureBox.Size = new Size(1323, 779);
            _pictureBox.TabIndex = 0;
            _pictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(drawTankButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 779);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(_valveStateComboBox);
            panel3.Controls.Add(_dripRateLabel);
            panel3.Controls.Add(_valveModeComboBox);
            panel3.Controls.Add(_valveStateLabel);
            panel3.Controls.Add(_dripRateNumericUpDown);
            panel3.Controls.Add(_valveModeLabel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 288);
            panel3.TabIndex = 9;
            // 
            // _valveStateComboBox
            // 
            _valveStateComboBox.AccessibleDescription = "";
            _valveStateComboBox.BackColor = SystemColors.Window;
            _valveStateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _valveStateComboBox.Font = new Font("Segoe UI", 10F);
            _valveStateComboBox.ForeColor = SystemColors.InfoText;
            _valveStateComboBox.FormattingEnabled = true;
            _valveStateComboBox.Items.AddRange(new object[] { "Открыт", "Закрыт" });
            _valveStateComboBox.Location = new Point(185, 81);
            _valveStateComboBox.Name = "_valveStateComboBox";
            _valveStateComboBox.Size = new Size(121, 25);
            _valveStateComboBox.TabIndex = 4;
            // 
            // _dripRateLabel
            // 
            _dripRateLabel.AutoSize = true;
            _dripRateLabel.Font = new Font("Segoe UI", 14F);
            _dripRateLabel.ForeColor = Color.White;
            _dripRateLabel.Location = new Point(43, 228);
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
            _valveModeComboBox.Items.AddRange(new object[] { "Вливание", "Сливание" });
            _valveModeComboBox.Location = new Point(185, 155);
            _valveModeComboBox.Name = "_valveModeComboBox";
            _valveModeComboBox.Size = new Size(121, 25);
            _valveModeComboBox.TabIndex = 3;
            _valveModeComboBox.Tag = "";
            // 
            // _valveStateLabel
            // 
            _valveStateLabel.AutoSize = true;
            _valveStateLabel.Font = new Font("Segoe UI", 14F);
            _valveStateLabel.ForeColor = Color.White;
            _valveStateLabel.Location = new Point(43, 79);
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
            _dripRateNumericUpDown.Location = new Point(186, 228);
            _dripRateNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _dripRateNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            _dripRateNumericUpDown.Name = "_dripRateNumericUpDown";
            _dripRateNumericUpDown.Size = new Size(120, 25);
            _dripRateNumericUpDown.TabIndex = 5;
            _dripRateNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // _valveModeLabel
            // 
            _valveModeLabel.AutoSize = true;
            _valveModeLabel.Font = new Font("Segoe UI", 14F);
            _valveModeLabel.ForeColor = Color.White;
            _valveModeLabel.Location = new Point(43, 153);
            _valveModeLabel.Name = "_valveModeLabel";
            _valveModeLabel.Size = new Size(71, 25);
            _valveModeLabel.TabIndex = 6;
            _valveModeLabel.Text = "Режим";
            // 
            // drawTankButton
            // 
            drawTankButton.Location = new Point(137, 558);
            drawTankButton.Name = "drawTankButton";
            drawTankButton.Size = new Size(80, 24);
            drawTankButton.TabIndex = 2;
            drawTankButton.Text = "Отобразить";
            drawTankButton.UseVisualStyleBackColor = true;
            drawTankButton.Click += button1_Click;
            // 
            // _timer
            // 
            _timer.Tick += _timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 779);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Liquid tank";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}
