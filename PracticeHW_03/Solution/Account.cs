//1. Базовый абстрактный класс 
public abstract class Account
{
    public double Balance { get; set; }
    public double Interest { get; set; }

    public abstract void CalculateInterest();

    // Общий функционал можно вынести сюда
    protected void ApplyMinMaxConstraints(double minValue, double maxValue)
    {
        if (Interest < minValue) Interest = minValue;
        if (Interest > maxValue) Interest = maxValue;
    }
}
