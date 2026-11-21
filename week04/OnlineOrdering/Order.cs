public class Order
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float TotalCost(Address address)
    {
        float total = 0;

        foreach (Product product in _products)
        {
            total += product.ProductPrice();
        }
        float shipping = address.IfUSA() ? 35 : 5;

        return total + shipping;
    }
    
    public void DisplayOrder(Customer customer, Address address)
    {
        Console.WriteLine("");
        Console.WriteLine($"Customer: {customer.GetName()}");
        Console.WriteLine("");
        Console.WriteLine("Products: ");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInfo());
        }
        Console.WriteLine("");
        Console.WriteLine($"Shipping Address: {address.GetAddress()}");
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: ${TotalCost(address)}");
    }
}