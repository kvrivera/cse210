/***
ABOVE AND BEYOND:
I opted to show the shipping cost separately,
as well as showing the total cost of the order
*/
/***
Author: Kathleen Rivera
Date: October 2024

Write a program that creates at least two orders 
with a 2-3 products each. Call the methods to get 
the packing label, the shipping label, and the 
total price of the order, and display the results 
of these methods.
*/
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // clear console

        ///// Order 1
        Address customer1Address = new Address("12 Grimmauld Place", "London", "London", "United Kingdom"); // customer1 address
        Customer customer1 = new Customer("Sirius Black", customer1Address);

        List<Product> productList1 = new List<Product>() // initialize a Product list to hold products
        {
            new Product("parchment paper", "99999", 2.39m, 1),
            new Product("How To Help Your Werewolf Friend, a book", "12345", 20.49m, 1),
            new Product("dog shampoo", "78978", 25.78m, 1)
        };

        Console.WriteLine("ORDER 1\n");
        Order order1 = new Order(customer1, productList1); // order1 instance
        string order1PackingLabel = order1.CreatePackingLabel();   // get packing label
        Console.WriteLine($"PACKING LABEL:\n{order1PackingLabel}"); // print packing label
        string customer1ShippingLabel = order1.CreateShippingLabel(customer1); // get shipping label
        Console.WriteLine($"SHIPPING LABEL:\n{customer1ShippingLabel}\n");// print shipping label
        decimal order1ShippingCost = order1.DetermineShippingCost(); // calculate shipping cost so it can be shown separately
        decimal order1TotalOrderCost = order1.CalculateTotalCost(); // get total price of order
        Console.WriteLine($"TOTAL COST: ${order1TotalOrderCost} \n(${order1ShippingCost} shipping included in price)\n"); // print total price of order

        ///// Order 2
        Address customer2Address = new Address("1007 Mountain Drive", "Gotham", "New Jersey", "USA"); // customer2 address
        Customer customer2 = new Customer("Bruce Wayne", customer2Address);

        List<Product> productList2 = new List<Product>() // initialize a Product list to hold products
        {
            new Product("batarang", "641342", 234.99m, 8),
            new Product("freshly laundered cape", "439889", 190.76m, 1)
        };

        Console.WriteLine();
        Console.WriteLine("ORDER 2\n");
        Order order2 = new Order(customer2, productList2); // order2 instance
        string order2PackingLabel = order2.CreatePackingLabel();   // get packing label
        Console.WriteLine($"PACKING LABEL:\n{order2PackingLabel}"); // print packing label
        string customer2ShippingLabel = order2.CreateShippingLabel(customer2); // get shipping label
        Console.WriteLine($"SHIPPING LABEL:\n{customer2ShippingLabel}\n");// print shipping label
        decimal order2ShippingCost = order2.DetermineShippingCost(); // calculate shipping cost so it can be shown separately
        decimal order2TotalOrderCost = order2.CalculateTotalCost(); // get total price of order
        Console.WriteLine($"TOTAL COST: ${order2TotalOrderCost} \n(${order2ShippingCost} shipping included in price)\n"); // print total price of order
    }
}