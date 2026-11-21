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


        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");


        Address address2 = new Address("Via Celimontana", "Roma", "Rome", "Italy");
        Customer customer2 = new Customer("Abby Bodily");
        Product product12 = new Product("Apples", "23DF355", 7, 1.25f);
        Product product22 = new Product("Bannanas", "837DFH", 8, 1.50f);
        Product product32 = new Product("Oranges", "9237DFG", 3, 1.25f);

        Order order2 = new Order();

        order2.AddProduct(product12);
        order2.AddProduct(product22);
        order2.AddProduct(product32);

        order2.DisplayOrder(customer2, address2);
    }
}