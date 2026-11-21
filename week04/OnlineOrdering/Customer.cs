public class Customer
{
    private string _customerName;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public string GetName()
    {
        return _customerName;
    }
}