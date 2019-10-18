using DDona.DesignPatterns.Decorator.Models.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Decorator.Models.OrderDecorator
{
    public class EverythingMustGoOrder : OrderDecorator
    {
        public EverythingMustGoOrder(OrderBase order) : base(order)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            double total = base.CalculateTotalOrderPrice();
            return (total * 0.95);
        }
    }
}
