class Product
{
    // Attributes / Variables
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;
    private decimal _totalProductCost;

    // Constructor(s)
    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    // Methods
    private decimal CalculateProductTotalCost(decimal _price, int _quantity)
    {
        decimal ProductTotalCost = _price * _quantity;
        return ProductTotalCost;
    }
}