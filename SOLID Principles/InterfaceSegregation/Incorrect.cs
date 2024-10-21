namespace SOLID_Principles.InterfaceSegregation.Incorrect;

public abstract class Bird
{
    public abstract double WingSpan { get; }
    public abstract void Fly();
}

public class Eagle : Bird
{
    public override double WingSpan => 2d;

    public override void Fly()
    {
        //Fly logic here;
    }
}

public class Penguin : Bird
{
    public override double WingSpan => 1d;

    public override void Fly()
    {
        throw new NotImplementedException();
    }
}
