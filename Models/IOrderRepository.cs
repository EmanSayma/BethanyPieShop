using System;
using System.Linq;
using System.Collections.Generic;

namespace BethanyPieShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}