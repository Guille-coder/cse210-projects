using System;

class Program
{
    static void Main(string[] args)
    {

        Customer customer1 = new Customer("Robet",(new Address("Ocean Drive","Miami","Florida","USA")));
        Order order1 = new Order(customer1);
        order1.productList(new Product("Mouse","100",85,2));
        order1.productList(new Product("Computer","99",258,1));

        Customer customer2 = new Customer("Guillermo",(new Address("26 de octubre","Piura","Piura","Perú")));
        Order order2 = new Order(customer2);
        order2.productList(new Product("Keyboard","122",154,2));
        order2.productList(new Product("Camera","56",80,1));
        order2.productList(new Product("Desk chair","103",267,1));

        List<Order> orders = new List<Order>();

        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            order.GetDisplayText();
        }   
                
    }
}