namespace LiquidTank;

internal interface IValveMode
{
    void Execute(Tank tank, double limit, System.Windows.Forms.Timer timer);
}
