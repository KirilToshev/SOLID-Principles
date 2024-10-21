namespace SOLID_Principles.DependencyInversion.Correct;

public class OrderService
{
    public readonly IDbContext dbContext;

    public OrderService(IDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void CreateOrder(params object[] orderDto)
    {
        var order = new { product = orderDto[0], count = orderDto[1] };
        dbContext.Add(order);
        dbContext.Save();
    }
}

public interface IDbContext
{
    bool Add(object entity);
    void Save();
}

public class DbContext : IDbContext
{
    public bool Add(object entity)
    {
        return true;
    }
    public void Save() { }
}