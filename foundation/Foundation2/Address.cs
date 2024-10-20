class Address
{
    // Attributes / Methods
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    // Methods
    public bool DetermineIfUSA()
    {
        bool AddressIsUSA = true;
        if (_country == "USA")
        {
            AddressIsUSA = true;
            return AddressIsUSA;
        }
        else if (_country != "USA")
        {
            AddressIsUSA = false;
            return AddressIsUSA;
        }
        return AddressIsUSA;
    }
    public string CreateAddress(string _street, string _city, string _state, string _country)
    {
        string AddressString = $"{_street}\n{_city}, {_state}\n{_country}";
        return AddressString;
    }
}