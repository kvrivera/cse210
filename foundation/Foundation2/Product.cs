class Product
{
    // Attributes / Variables
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    // Constructor(s)
    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    // Methods
    public decimal CalculateProductTotalCost()
    {
        decimal ProductTotalCost = _price * _quantity;
        return ProductTotalCost;
    }
    public string ShowProductName() // need this for Packing Label (Order class)
    {
        return _name;
    }
    public string ShowProductID() // need this for Packing Label (Order class)
    {
        return _productID;
    }
}