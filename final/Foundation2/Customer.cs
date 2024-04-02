using System;

public class Customer
{
    private string _name; 
    private Address _address;   //inherited from address class

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName() => _name;

    public bool IsUSA() => _address.IsInUSA() ? true : false;   //shortcut for T / F

    public string GetFullAddress() => _address.GetFullAddress();
}
