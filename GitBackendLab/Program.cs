using GitBackendLab.Models;
using GitBackendLab.Services;
using System.Numerics;

namespace GitBackendLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 1,
                Total = 19
            };

            var orderService = new OrderServices();

            var total = orderService.Calculate(order);

            Console.WriteLine($"Order #{order.Id} ,Final Total = {total}");

            Console.WriteLine("Any thing");
        }
    }
}
