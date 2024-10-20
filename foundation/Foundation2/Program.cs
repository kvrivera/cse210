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

        Address customer1Address = new Address("12 Grimmauld Place", "London", "London", "United Kingdom"); // customer1 address
        Customer customer1 = new Customer("Sirius Black", customer1Address);

        List<Product> productList1 = new List<Product>(); // initialize a Product list to hold products
        Product product1 = new Product("vinegar", "99999", 2.39m, 1);
        productList1.Append(product1); // append to product list
        Product product2 = new Product("laundry detergent", "12345", 20.49m, 1);
        productList1.Append(product2); // append to product list

        Order order1 = new Order(customer1, productList1); // order1 instance
        // get packing label
        // print packing label
        // get shipping label
        // print shipping label
        // get total price of order
        // print total price of order

    }
}