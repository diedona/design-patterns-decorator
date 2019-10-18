using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.DesignPatterns.Decorator.Models.Order
{
    public class PreOrder : OrderBase
    {
        public PreOrder(List<Product> products) : base(products)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            double total = this.Products.Sum(x => x.Value);
            return (total * 0.9);
        }
    }
}
