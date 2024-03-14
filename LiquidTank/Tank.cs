using System.Drawing.Drawing2D;

namespace LiquidTank;

internal class Tank(double currentLiquidVolume = 500, double maxLiquidVolume = 1000, double dripRate = 10)
{     
    private double _currentLiquidVolume = (currentLiquidVolume < maxLiquidVolume && currentLiquidVolume > 0) ? currentLiquidVolume : 0;
    private double _maxLiquidVolume = (maxLiquidVolume > 0) ? maxLiquidVolume : 1000;
    private double _dripRate = (dripRate > 0 && dripRate < 1000) ? dripRate : 10;

    public bool IsValveOpened { get; private set; }
    public Rectangle TankRectangle { get; private set; }
    public IValveMode? ValveMode { get; private set; }
    public double DripRate { set { _dripRate = (value > 0) ? value : _dripRate; } get { return _dripRate; } }
    public double MaxLiquidVolume => _maxLiquidVolume;
    public double CurrentLiquidVolume => _currentLiquidVolume;

    public void DrawTank(PictureBox pictureBox)
    {
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        GraphicsPath path = new() { FillMode = FillMode.Winding };

        CreateTankRect(pictureBox, 400);

        using (Graphics g = Graphics.FromImage(bitmap))
        {
            Pen pen = new(Color.Black, 3);
            g.SmoothingMode = SmoothingMode.HighQuality;
            path.AddRectangle(TankRectangle);
            g.DrawPath(pen, path);

            pen.Dispose();
            g.Dispose();
        }
        pictureBox.Image = bitmap;
    }

    private void CreateTankRect(PictureBox pictureBox, int scale)
    {
        int centerX = pictureBox.Width / 2;
        int centerY = pictureBox.Height / 2;

        TankRectangle = new(centerX, centerY, scale, scale);
    }

    public void DrawLiquid(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        pictureBox.Refresh();
        double volume = ConvertToPercent(_currentLiquidVolume);

        Color brushColor = Color.Aqua;
        SolidBrush brush = new(brushColor);
        g.FillRectangle(brush, TankRectangle.X, (float)(TankRectangle.Y + TankRectangle.Height - volume), TankRectangle.Width, (float)volume);           
        g.Dispose();
        brush.Dispose();          
    }

    public void PourIn(int count) => _currentLiquidVolume += count;
    
    public void DrainOut(int count) => _currentLiquidVolume -= count;
    
    public void OpenValve() =>  IsValveOpened = true; 

    public void CloseValve() =>  IsValveOpened = false;
    
    public void SetValveMode(IValveMode mode) => ValveMode = mode;
    
    public double ConvertToPercent(double value)
    {
        return TankRectangle.Height / _maxLiquidVolume * value;
    }
}
