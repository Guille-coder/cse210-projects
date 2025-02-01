using System;

public class Order
{
    private int _totalPrice;
    private Customer _customer;
    List<Product> _products = new List<Product>();

    public Order()
    {

    }
    public Order(Customer customer)
    {
        _customer = customer;

    }
    public void productList (Product product)
    {
        
        _products.Add(product);
        
    }
    public int GetTotal()
    {
    
        if (_customer.LiveInUsa() == true)
        {

            return _totalPrice +5;

        }
        else
        {
            return  _totalPrice +35;

        }          
    }    
    public void GetDisplayText()
    {
        Console.WriteLine("Packing Label:");

        int sum = 0;
        foreach (Product product in _products)
        {
            product.display();
            sum += product.TotalCost();

        }
        _totalPrice = sum +GetTotal();

        Console.WriteLine("---------------------- ");
        Console.WriteLine("Shipping Label:");

        _customer.DisplayCustomer();
        // _totalPrice += GetTotal();
        Console.WriteLine($"Total Price: ${_totalPrice.ToString("F2")}\n");

        

    }
    
   
}