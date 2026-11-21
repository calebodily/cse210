using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address("183 Main Street", "San Francisco", "California", "USA");
        Customer customer = new Customer("Trinity Smith");
        Product product1 = new Product("Apples", "23DF355", 3, 1.25f);
        Product product2 = new Product("Bannanas", "837DFH", 5, 1.50f);
        Product product3 = new Product("Oranges", "9237DFG", 4, 1.25f);

        Order order = new Order();

        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        order.DisplayOrder(customer, address);
    }
}