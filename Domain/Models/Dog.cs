using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Restaurant.Domain.Models
{
    class Dog : IChef
    {
        public void Cook(Order order)
        {
            order.StartOrder();

            WriteLine($"Cooking {order.Dish}...");

            Thread.Sleep(2000);

            order.OrderCompleted();
        }
    }
}
