namespace SOLID_Principles.DependencyInversion.Incorrect;

public class OrderService
{
    public readonly DbContext dbContext;

    public OrderService()
    {
        dbContext = new DbContext();
    }

    public void CreateOrder(params object[] orderDto)
    {
        var order = new { product = orderDto[0], count = orderDto[1] };
        dbContext.Add(order);
        dbContext.Save();
    }
}

public class DbContext
{
    public bool Add(object entity)
    {
        return true;
    }
    public void Save() { }
}