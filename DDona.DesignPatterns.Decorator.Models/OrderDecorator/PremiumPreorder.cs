using System;
using System.Collections.Generic;
using System.Text;
using DDona.DesignPatterns.Decorator.Models.Order;

namespace DDona.DesignPatterns.Decorator.Models.OrderDecorator
{
    public class PremiumPreorder : OrderDecorator
    {
        public PremiumPreorder(PreOrder order) : base(order)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            double total = base.CalculateTotalOrderPrice();
            return (total * 0.9);
        }
    }
}
