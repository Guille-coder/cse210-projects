using System;

public class Product
{
    private string _nameOfProduct;
    private string _productId;
    private int _priceOfProduct;
    private int _quantityOfProduct;

    public Product(string nameProduct, string id, int price, int quantity)
    {
        _nameOfProduct = nameProduct;
        _productId = id;
        _priceOfProduct = price;
        _quantityOfProduct = quantity;
    }
    public int TotalCost()
    {
        return _priceOfProduct * _quantityOfProduct;
    }
    public void display()
    {
        Console.WriteLine($"Name:{_nameOfProduct}, Product ID:{_productId}");
    }


}