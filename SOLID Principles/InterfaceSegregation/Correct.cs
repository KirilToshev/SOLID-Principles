namespace SOLID_Principles.InterfaceSegregation.Correct;

public interface IFlyable
{
    public void Fly();
}

public abstract class Bird
{
    public abstract double WingSpan { get; }
}

public class Eagle : Bird, IFlyable
{
    public override double WingSpan => 2d;

    public void Fly()
    {
        //Fly logic here;
    }
}

public class Penguin : Bird
{
    public override double WingSpan => 1d;
}
