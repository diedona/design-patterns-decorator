using DDona.DesignPatterns.Decorator.Models;
using DDona.DesignPatterns.Decorator.Models.Order;
using DDona.DesignPatterns.Decorator.Models.OrderDecorator;
using System;
using System.Collections.Generic;

namespace DDona.DesignPatterns.Decorator.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ Name = "DVD", Value = 250.98 },
                new Product(){ Name = "Blue Ray", Value = 450}
            };

            RegularOrder regular = new RegularOrder(products);
            Console.WriteLine($"regular order total: {regular.CalculateTotalOrderPrice().ToString("C")}");

            PreOrder pre = new PreOrder(products);
            Console.WriteLine($"pre order total: {pre.CalculateTotalOrderPrice().ToString("C")}");

            // NOW WE USE A DECORATOR
            PremiumPreorder premiumPre = new PremiumPreorder(pre);
            Console.WriteLine($"pre order total for premium: {premiumPre.CalculateTotalOrderPrice().ToString("C")}");

            // ANOTHER ONE
            EverythingMustGoOrder everythingOrder = new EverythingMustGoOrder(regular);
            Console.WriteLine($"everything must go (regular) order total: {everythingOrder.CalculateTotalOrderPrice().ToString("C")}");

            EverythingMustGoOrder everythingPreOrder = new EverythingMustGoOrder(pre);
            Console.WriteLine($"everything must go (pre) order total: {everythingPreOrder.CalculateTotalOrderPrice().ToString("C")}");
        }
    }
}
