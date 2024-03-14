using System.Collections.Generic;

namespace LiquidTank;

internal class PouringMode : IValveMode
{
    public void Execute(Tank tank, double limit, System.Windows.Forms.Timer timer)
    {
        double volume = tank.ConvertToPercent(limit);

        if (volume > tank.TankRectangle.Height || volume < tank.ConvertToPercent(tank.CurrentLiquidVolume) ||
            tank.ConvertToPercent(tank.CurrentLiquidVolume) == volume || tank.IsValveOpened == false)
        {
            timer.Stop();
            return;
        }

        tank.PourIn(10);
    }
}
