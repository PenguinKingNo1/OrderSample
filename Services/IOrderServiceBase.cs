using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSample.Models;

namespace OrderSample.Services
{
    public interface IOrderServiceBase
    {
        void AddService(ServiceBase service); // Service is a class defined somewhere
        void CancelOrder();
        void SendToBilling();
    }
}
