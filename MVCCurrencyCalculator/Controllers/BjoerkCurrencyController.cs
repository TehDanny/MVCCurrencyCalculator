using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCurrencyCalculator.Controllers
{
    public class BjoerkCurrencyController : Controller
    {
        // GET: BjoerkCurrency
        public ActionResult Index()
        {
            List<Models.BjoerkCurrency> currencyList = new List<Models.BjoerkCurrency>();
            currencyList.Add(new Models.BjoerkCurrency("DKK", "Denmark", 100.00M));
            currencyList.Add(new Models.BjoerkCurrency("EUR", "Euro", 745.99M));
            return View(currencyList);
        }

        // GET: BjoerkCurrency/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: BjoerkCurrency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BjoerkCurrency/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BjoerkCurrency/Edit/5
        public ActionResult Edit(string id)
        {
            List<Models.BjoerkCurrency> currencies = new List<Models.BjoerkCurrency>();
            currencies.Add(new Models.BjoerkCurrency("EUR", "Euro", 745.99M));
            currencies.Add(new Models.BjoerkCurrency("SEK", "Sweden", 78.21M));
            Models.BjoerkCurrency chosenCurrency = currencies[0];
            return View(chosenCurrency);
        }

        // POST: BjoerkCurrency/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Models.BjoerkCurrency model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BjoerkCurrency/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: BjoerkCurrency/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
