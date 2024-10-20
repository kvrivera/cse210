using System.Net.Sockets;

class Customer
{
    // Attributes / Variables
    private string _name;
    private Address _address;

    // Constructor(s)
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Methods
    public bool DetermineIfAmerican()
    {
        bool customerIsAmerican = _address.DetermineIfUSA();
        return customerIsAmerican;
    }
    public string ShowCustomerName() // need this for Order Shipping Label
    {
        return _name;
    }
    public string ShowCustomerAddress()
    {
        string addressString = _address.CreateAddress();
        return addressString;
    }
}