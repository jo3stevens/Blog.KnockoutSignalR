using KnockoutSignalR.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutSignalR.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new CurrencyViewModel()
            {
                Currencies = CurrencyService.GetCurrencies()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(CurrencyViewModel viewModel)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<CurrencyHub>();
            viewModel.Currencies.ForEach(c => context.Clients.All.updateCurrency(c.Code, c.Price));
            return View(viewModel);
        }
    }
}
