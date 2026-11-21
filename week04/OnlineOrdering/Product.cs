public class Product
{
    private string _productName;
    private int _quantity;
    private float _price;
    private string _productId;

    public Product(string name, string productId, int quantity, float price)
    {
        _productName = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public float ProductPrice()
    {
        return _quantity * _price;
    }

    public string GetProductInfo()
    {
        return $"{_productName} ({_productId}) - Quantity: {_quantity}, Price: ${ProductPrice()}";
    }
}