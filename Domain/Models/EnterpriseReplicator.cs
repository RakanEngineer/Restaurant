using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Restaurant.Domain.Models
{
    class EnterpriseReplicator : IChef
    {
        public void Cook(Order order)
        {
            order.StartOrder();

            WriteLine($"Cooking {order.Dish}...");

            Thread.Sleep(100);

            order.OrderCompleted();
        }
    }
}
