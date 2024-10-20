using System.Reflection.Metadata.Ecma335;

class Order
{
    // Attributes / Variables
    private Customer _customer;
    private List<Product> _products;

    // Constructor(s)
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>(products); // initialize the list
    }
    // Methods
    private decimal CalculateTotalCost()
    {
        return decimal;
    }

    private string CreatePackingLabel(List<Product> _products)
    {
        return "";
    }

    private string CreateShippingLabel(Customer _customer)
    {
        return "";
    }
}