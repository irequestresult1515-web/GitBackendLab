using GitBackendLab.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBackendLab.Services
{
    public class OrderServices
    {
        public decimal Calculate(Order order)
        {
            return order.Total * 0.7m;
        }

        public bool IsHighValueOrder(Order order)
        {
            return order.Total >= 500m;
        }

        public void MakeItDone(Order order)
        {
            order.Status = "Done";
        }
    }

}
