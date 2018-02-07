using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSample.Models;
using OrderSample.Services;

namespace OrderSample.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderServiceBase _orderServiceBase;
        public OrdersController(IOrderServiceBase orderServiceBase)
        {
            _orderServiceBase = orderServiceBase;
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            // create dummy data for testing, all these should come from reposiotry layer in real world
            List<OrderBase> orderList = new List<OrderBase>
            {
                new Paramed()
                {
                    OrderId = 1, AccountNumber = "01234567890", CustomerFirstName = "FN1", CustomerLastName = "LN1",
                    Services = new List<ServiceBase>(){new SomeService(), new SomeService() }
                },
                new CreditCheck()
                {
                    OrderId = 2, AccountNumber = "12234567890", CustomerFirstName = "FN2", CustomerLastName = "LN2",
                    Services = new List<ServiceBase>(){new SomeService()}
                },
                new CriminalReport()
                {
                    OrderId = 3, AccountNumber = "42234567890", CustomerFirstName = "FN3", CustomerLastName = "LN3",
                    Services = new List<ServiceBase>(){new SomeService(), new SomeService() , new SomeService() }
                }
            };
            return Json(orderList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddService()
        {
            // AddService may be implemented by different order service
            _orderServiceBase.AddService(new SomeService());
            return View();
        }
    }
}