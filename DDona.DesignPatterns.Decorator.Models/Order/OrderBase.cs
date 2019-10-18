using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Decorator.Models.Order
{
    public abstract class OrderBase
    {
        public List<Product> Products { get; set; }

        public OrderBase(List<Product> products)
        {
            this.Products = products;
        }

        public abstract double CalculateTotalOrderPrice();
    }
}
