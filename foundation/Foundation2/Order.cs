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
        decimal shippingCost = DetermineShippingCost();
        decimal orderTotalCost = shippingCost; // start with the shipping cost

        foreach (Product product in _products)
        {
            decimal productTotalCost = product.CalculateProductTotalCost();
            orderTotalCost += productTotalCost; // add the product's cost to the order's total cost
        }

        return orderTotalCost; // shipping cost + product costs
    }

    public string CreatePackingLabel()
    {
        string packingLabelString = "";

        foreach (Product product in _products)
        {
            string productName = product.ShowProductName();
            string productID = product.ShowProductID();
            string productString = $"{productName} ({productID})";
            packingLabelString += productString + "\n";
        }
        return packingLabelString;
    }

    public string CreateShippingLabel(Customer _customer)
    {
        string customerName = _customer.ShowCustomerName();
        string customerAddress = _customer.ShowCustomerAddress();

        string shippingLabelString = $"{customerName}\n{customerAddress}";
        return shippingLabelString;
    }
}