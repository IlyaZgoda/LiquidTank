using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LiquidTank;

public partial class Form1 : Form
{
    Tank tank = new();

    public Form1()
    {
        InitializeComponent();
        _timer.Tick += Timer_Tick;

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

    private void Timer_Tick(object sender, EventArgs e)
    {
        tank.DrawLiquid(_pictureBox);           

        if(tank.Mode == ValveMode.Pouring)
        {
            tank.PourIn((double)_limitVolumeNumericUpDown.Value);           
        }
        else if(tank.Mode == ValveMode.Draining)
        {
            tank.DrainOut((double)_limitVolumeNumericUpDown.Value);
        }
        _currentVolumeValueLabel.Text = tank.CurrentLiquidVolume.ToString();
    }

    private void DripRateNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        tank.DripRate = (double)_dripRateNumericUpDown.Value;
        _timer.Interval = (int)_dripRateNumericUpDown.Value;
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
        tank.SetValveMode((ValveMode)_valveModeComboBox.SelectedIndex);
    }
}
