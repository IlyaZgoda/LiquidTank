using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidTank
{
    internal class Tank
    {
        private bool _isValveOpened;
        private int _valveMode;
        private double _currentLiquidVolume;
        private double _maxLiquidVolume;
        private double _dripRate;
        private double _liquidPercent;
        private Rectangle _rectangle;

        public double DripRate { set { _dripRate = (value > 0) ? value : _dripRate; } get { return _dripRate; } }

        public Tank(double currentLiquidVolume = 0, double maxLiquidVolume = 1000) 
        {
            _currentLiquidVolume = (currentLiquidVolume < maxLiquidVolume && currentLiquidVolume > 0) ? currentLiquidVolume : 0;
            _maxLiquidVolume = (maxLiquidVolume > 0) ? maxLiquidVolume : 1000;           
        }   
        
        public void DrawTank(PictureBox pictureBox)
        {
            Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
            GraphicsPath path = new() { FillMode = FillMode.Winding };

            CreateTankRect(pictureBox, 360);

            using (Graphics g = Graphics.FromImage(bitmap))
            {               
                Pen pen = new(Color.Black, 3);
                Pen dottedPen = new(Color.Black, 0.5f) { DashStyle = DashStyle.DashDotDot };        

                g.SmoothingMode = SmoothingMode.HighQuality;               

                path.AddRectangle(_rectangle);

                g.DrawPath(pen, path);
                //g.DrawArc(pen, centerX - radius, centerY - radius, 2 * radius, radius, 0, 180);
                //g.DrawArc(dottedPen, centerX - radius, centerY + radius, 2 * radius, radius, 180, 180);

                //g.DrawRectangle(pen, _rectangle.X, (float)(_rectangle.Y + _rectangle.Height - _currentLiquidVolume), _rectangle.Width, (float)_currentLiquidVolume);

                DrawLiquid(g);

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

        public void DrawLiquid(Graphics g)
        {
            Color brushColor = Color.Red;
            SolidBrush brush = new(brushColor);
            g.FillRectangle(brush, _rectangle.X, (float)(_rectangle.Y + _rectangle.Height - _liquidPercent), _rectangle.Width, (float)_liquidPercent);
            g.Dispose();
            brush.Dispose();
        }
        public void PourIn()
        {
            _liquidPercent = _rectangle.Height / _maxLiquidVolume * _currentLiquidVolume;

            if (_liquidPercent == _rectangle.Height) return;

             _currentLiquidVolume += 10;

        }

        public void OpenValve()
        {
            _isValveOpened = true;
        }

        public void CloseValve()
        {
            _isValveOpened = false;
        }
    }

    //public void PourIn(PictureBox pictureBox)
    //{
    //    double percentage = _rectangle.Height / _maxLiquidVolume * _currentLiquidVolume;
    //    if (percentage == _rectangle.Height) return;

    //    Graphics g = pictureBox.CreateGraphics();
    //    _currentLiquidVolume += 10;

    //    Color brushColor = Color.Red;
    //    SolidBrush brush = new(brushColor);

    //    g.FillRectangle(brush, _rectangle.X, (float)(_rectangle.Y + _rectangle.Height - percentage), _rectangle.Width, (float)percentage);

    //    g.Dispose();
    //    brush.Dispose();
    //}
}
