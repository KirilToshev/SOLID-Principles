namespace SOLID_Principles.SingleResponsibility.Incorrect;

public class ProductService
{
    private char[] invalidNameCharecters = [' ', '$', '%'];

    public bool CreateProduct(string name)
    {
        if (IsNameValid(name)) 
        {
            var product = new Product();
            product.Name = name;

            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsNameValid(string name)
    {
        var invalidName = invalidNameCharecters.Any(c => name.Contains(c));
        return !invalidName;
    }
}

internal class Product
{
    public string Name { get; set; }
}