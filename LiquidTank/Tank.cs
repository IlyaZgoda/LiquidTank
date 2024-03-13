using System.Drawing.Drawing2D;

namespace LiquidTank;

internal class Tank(double currentLiquidVolume = 500, double maxLiquidVolume = 1000, double dripRate = 10)
{
    private bool _isValveOpened;      
    private double _currentLiquidVolume = (currentLiquidVolume < maxLiquidVolume && currentLiquidVolume > 0) ? currentLiquidVolume : 0;
    private double _maxLiquidVolume = (maxLiquidVolume > 0) ? maxLiquidVolume : 1000;
    private double _dripRate = (dripRate > 0 && dripRate < 1000) ? dripRate : 10;  
    private Rectangle _rectangle;

    public ValveMode Mode { get; set; }
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
            path.AddRectangle(_rectangle);
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

        _rectangle = new(centerX, centerY, scale, scale);
    }

    public void DrawLiquid(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        pictureBox.Refresh();
        double volume = ConvertToPercent(_currentLiquidVolume);

        Color brushColor = Color.Aqua;
        SolidBrush brush = new(brushColor);
        g.FillRectangle(brush, _rectangle.X, (float)(_rectangle.Y + _rectangle.Height - volume), _rectangle.Width, (float)volume);           
        g.Dispose();
        brush.Dispose();          
    }

    public void PourIn(double limit)
    {
        double volume = ConvertToPercent(limit);

        if(volume > _rectangle.Height || volume < ConvertToPercent(_currentLiquidVolume)) return;

        if (ConvertToPercent(_currentLiquidVolume) == volume || _isValveOpened == false) return;

         _currentLiquidVolume += 10;       
    }

    public void DrainOut(double limit)
    {
        double volume = ConvertToPercent(limit);

        if(volume < 0 || volume > ConvertToPercent(_currentLiquidVolume)) return;

        if (ConvertToPercent(_currentLiquidVolume) == volume || _isValveOpened == false) return;

        _currentLiquidVolume -= 10;
    }

    public void OpenValve()
    {
        _isValveOpened = true;
    }

    public void CloseValve()
    {
        _isValveOpened = false;
    }

    public void SetValveMode(ValveMode mode)
    {
        Mode = mode;
    }

    private double ConvertToPercent(double value)
    {
        return _rectangle.Height / _maxLiquidVolume * value;
    }
}
