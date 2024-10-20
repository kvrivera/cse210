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
    private bool DetermineIfAmerican(Address _address)
    {
        if (/*address contains "USA" */) // fix syntax 
        {

        }
        bool CustomerIsAmerican = true;
        return true;
    }
}