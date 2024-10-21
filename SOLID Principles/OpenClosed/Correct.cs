namespace SOLID_Principles.OpenClosed.Correct;

public class ElectricityService
{
    private readonly ITariffCalculator[] _tariffCalculator = 
        [ new DayTariffCalculator(), new NightTariffCalculator() ];

    public decimal CalculateElectricityCost(int consumption, Tariff tariff)
    {
        return _tariffCalculator
            .First(calculator => calculator.Tariff == tariff)
            .CalculateCost(consumption);
    }
}

public enum Tariff
{
    Day = 1,
    Night = 2
}

public interface ITariffCalculator
{
    Tariff Tariff { get; }

    decimal CalculateCost(int consumption);
}

public class DayTariffCalculator : ITariffCalculator
{
    public Tariff Tariff => Tariff.Day;

    public decimal CalculateCost(int consumption)
    {
        return consumption * 2m;
    }
}

public class NightTariffCalculator : ITariffCalculator
{
    public Tariff Tariff => Tariff.Night;

    public decimal CalculateCost(int consumption)
    {
        return consumption * 1.5m;
    }
}