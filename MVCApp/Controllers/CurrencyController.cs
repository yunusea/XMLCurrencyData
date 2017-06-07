using Models.Model;
using MVCApp.ViewModel;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: Currency
        public ActionResult Index()
        {
            var model = new CurrencyViewModel();
            using (var service = new CurrencyDataService())
            {
                 model.CurrencyList = service.GetAllCurrencyData();
            }
            return View(model);
        }

        public ActionResult Edit(int Id)
        {
            var model = new CurrencyData();
            using (var service = new CurrencyDataService())
            {
                model = service.GetById(Id);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CurrencyData model)
        {
            using (var service = new CurrencyDataService())
            {
                model = service.Update(model);
            }
            return RedirectToAction("Index", "Currency");
        }
    }
}