using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBackendLab.Modles
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
