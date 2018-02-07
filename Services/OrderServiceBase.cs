using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSample.Models;

namespace OrderSample.Services
{
    public abstract class OrderServiceBase : IOrderServiceBase
    {
        public virtual void AddService(ServiceBase service)
        {
            // Generic add behavior, may be overriden
        }

        public virtual void CancelOrder()
        {
            // Generic cancel behavior, may be overriden
        }

        public virtual void SendToBilling()
        {
            // Generic send behavior, may be overriden
        }
    }
}
