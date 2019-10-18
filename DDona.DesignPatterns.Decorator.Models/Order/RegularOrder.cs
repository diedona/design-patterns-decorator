using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.DesignPatterns.Decorator.Models.Order
{
    public class RegularOrder : OrderBase
    {
        public RegularOrder(List<Product> products) : base(products)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            return this.Products.Sum(x => x.Value);
        }
    }
}
