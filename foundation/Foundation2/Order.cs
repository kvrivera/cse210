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
    public decimal DetermineShippingCost()
    {
        bool isAmerican = _customer.DetermineIfAmerican();
        decimal shippingCost = 0.00m;

        if (isAmerican == true)
        {
            shippingCost = 5.00m;
        }
        else if (isAmerican == false)
        {
            shippingCost = 35.00m;
        }
        return shippingCost;

    }
    public decimal CalculateTotalCost()
    {
        return decimal;
    }

    private string CreatePackingLabel(List<Product> _products)
    {
        foreach ()
        {

        } // forEach loop to return the name and product ID of each product as a string
        return "";
    }

    public string CreateShippingLabel(Customer _customer)
    {
        string customerName = _customer.ShowCustomerName();
        string customerAddress = _customer.ShowCustomerAddress();

        string shippingLabelString = $"{customerName}\n{customerAddress}";
        return shippingLabelString;
    }
}