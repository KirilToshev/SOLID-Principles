namespace SOLID_Principles.OpenClosed.Incorrect;

public class ElectricityService
{
    public decimal CalculateElectricityCost(int consumption, Tariff tariff)
    {
        var cost = 0m;
        switch (tariff)
        {
            case Tariff.Day:
                cost = consumption * 2m;
                break;
            case Tariff.Night:
                cost = consumption * 1.5m;
                break;
        }

        return cost;
    }
}

public enum Tariff
{
    Day = 1,
    Night = 2
}
