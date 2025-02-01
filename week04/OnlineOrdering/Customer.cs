using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;


    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }
    public bool LiveInUsa()
    {
        return _customerAddress.GetCountry();
    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}");
        Console.WriteLine($"{_customerAddress.FieldsTogether()}");
    }
}