using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LiquidTank
{
    public partial class Form1 : Form
    {
        Tank tank = new(500);

        public Form1()
        {
            InitializeComponent();
            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            tank.DrawTank(_pictureBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _valveStateComboBox.SelectedIndex = 0;
            _valveModeComboBox.SelectedIndex = 0;
            tank.DripRate = (double)_dripRateNumericUpDown.Value;
            //_timer.Interval = (int)_dripRateNumericUpDown.Value;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            tank.PourIn();
            tank.DrawLiquid(_pictureBox.CreateGraphics());
        }
    }
}
