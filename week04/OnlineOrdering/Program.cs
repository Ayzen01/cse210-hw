using System;
using System.Collections.Generic;

class ProgramOrders
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        
        Address addr1 = new Address("Av. Rebouças ,1200", "Sumare", "SP", "Brasil");
        Customer client1 = new Customer("Emanoel Morais", addr1);
        Order order1 = new Order (client1);

        order1.AddProduct(new Product("Mechanical Keyboard", "k820",45.00,1));
        order1.AddProduct(new Product("Mouse Gamer", "M300", 25.50,2));
        

        Address addr2 = new Address("123 Main street", "Salt Lake City", "UT", "USA");
        Customer client2 = new Customer("Jonh Dan",addr2);
        Order order2 = new Order (client2);

        order2.AddProduct(new Product("24-inch monitor", "MON-4K", 180.00,1));
        order2.AddProduct(new Product("HDMI cable","HDMI-02",8.99,3));
        order2.AddProduct(new Product("Monitor Stand", "SUP-01",35.00,1));
        

        Console.WriteLine("==========================================");
        Console.WriteLine("              ORDERING SYSTEM             ");
        Console.WriteLine("=========================================");
        


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price of the order 1 : US$ {order1.CalculateTotalOrderPrice}");
        Console.WriteLine("\n------------------------------------------\n");


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order 2 Price: US$ {order2.CalculateTotalOrderPrice():F2}");

    }
}










    
