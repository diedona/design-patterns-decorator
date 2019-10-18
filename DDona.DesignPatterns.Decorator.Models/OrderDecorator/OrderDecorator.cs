using DDona.DesignPatterns.Decorator.Models.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.DesignPatterns.Decorator.Models.OrderDecorator
{
    public abstract class OrderDecorator : OrderBase
    {
        protected OrderBase Order;

        public OrderDecorator(OrderBase order) : base(order.Products)
        {
            this.Order = order;
        }

        public override double CalculateTotalOrderPrice()
        {
            return this.Order.CalculateTotalOrderPrice();
        }
    }
}
