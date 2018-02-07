using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample.Models
{
    public abstract class OrderBase
    {
        public int? OrderId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string AccountNumber { get; set; }
        public virtual ICollection<ServiceBase> Services { get; set; }
    }
}
