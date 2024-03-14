namespace LiquidTank;

internal class DrainingMode : IValveMode
{
    public void Execute(Tank tank, double limit, System.Windows.Forms.Timer timer)
    {
        double volume = tank.ConvertToPercent(limit);

        if (volume < 0 || volume > tank.ConvertToPercent(tank.CurrentLiquidVolume) ||
        tank.ConvertToPercent(tank.CurrentLiquidVolume) == volume || tank.IsValveOpened == false)
        {
            timer.Stop();
            return;
        }

        tank.DrainOut(10);
    }
}
