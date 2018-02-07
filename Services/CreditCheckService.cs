using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSample.Models;

namespace OrderSample.Services
{
    public class CreditCheckService : OrderServiceBase
    {
        public override void AddService(ServiceBase service)
        {
            // CreditCheck add behavior
        }

        public override void CancelOrder()
        {
            // CreditCheck cancel behavior
        }

        public override void SendToBilling()
        {
            // CreditCheck send behavior
        }
    }
}
