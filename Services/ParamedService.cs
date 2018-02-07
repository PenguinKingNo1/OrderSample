using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSample.Models;

namespace OrderSample.Services
{
    public class ParamedService : OrderServiceBase
    {
        public override void AddService(ServiceBase service)
        {
            // Paramed add behavior
        }

        public override void CancelOrder()
        {
            // Paramed cancel behavior
        }

        public override void SendToBilling()
        {
            // Paramed send behavior
        }
    }
}
