using CSharpFunctionalExtensions;

namespace SOLID_Principles.SingleResponsibility.Correct;

public class ProductService(char[] invalidNameCharecters)
{
    private readonly char[] _invalidNameCharecters = invalidNameCharecters;

    public bool CreateProduct(string name)
    {
        if (Product.Create(name, _invalidNameCharecters).IsFailure)
        {
            return false;
        }

        return true;
    }
}

public class Product
{
    private Product(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public static Result<Product> Create(string name, char[] invalidNameCharecters)
    {
        if (invalidNameCharecters.Any(c => name.Contains(c)))
        {
            return Result.Failure<Product>("Name can not contain invalid charecters.");
        }
        else
        {
            return new Product(name);
        }
    }
}