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
            return order.total * 0.85m;
        }
    }
}
