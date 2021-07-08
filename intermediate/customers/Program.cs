using System;
using System.Collections.Generic;
using System.IO;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}
