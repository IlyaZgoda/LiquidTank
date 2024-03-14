using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LiquidTank;

public partial class Form1 : Form
{
    private readonly Tank tank = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _timer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        tank.DrawTank(_pictureBox);
        tank.DrawLiquid(_pictureBox);      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _valveModeComboBox.DataSource = Enum.GetNames(typeof(ValveMode));
        _valveStateComboBox.SelectedIndex = 0;
        _dripRateNumericUpDown.Value = (decimal)tank.DripRate;
        _timer.Interval = (int)tank.DripRate;
        _maxVolumeValueLlabel.Text = tank.MaxLiquidVolume.ToString();
        _currentVolumeValueLabel.Text = tank.CurrentLiquidVolume.ToString();
    }

    private async void Timer_Tick(object sender, EventArgs e)
    {
        await Task.Run(() => tank.ValveMode?.Execute(tank, (double)_limitVolumeNumericUpDown.Value, _timer));
        tank.DrawLiquid(_pictureBox);
        _currentVolumeValueLabel.Text = tank.CurrentLiquidVolume.ToString();
    }

    private void DripRateNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        tank.DripRate = (double)_dripRateNumericUpDown.Maximum - (double)_dripRateNumericUpDown.Value;
        _timer.Interval = (int)(_dripRateNumericUpDown.Maximum - (int)_dripRateNumericUpDown.Value);
    }

    private void ValveStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch(_valveStateComboBox.SelectedIndex)
        {
            case 0: tank.CloseValve(); break;
            case 1: tank.OpenValve(); break;
        }
    }

    private void ValveModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch((ValveMode)_valveModeComboBox.SelectedIndex)
        {
            case ValveMode.Pouring: tank.SetValveMode(new PouringMode()); break;
            case ValveMode.Draining: tank.SetValveMode(new DrainingMode()); break;
        }
    }
}
