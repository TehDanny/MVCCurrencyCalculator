using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCurrencyCalculator.Controllers
{
    public class BjoerkCurrencyExchangeController : Controller
    {
        // GET: BjoerkCurrencyExchange
        public ActionResult Index()
        {
            List<Models.BjoerkCurrency> currencies = new List<Models.BjoerkCurrency>();
            currencies.Add(new Models.BjoerkCurrency("EUR", "Euro", 745.99M));
            currencies.Add(new Models.BjoerkCurrency("SEK", "Sweden", 78.21M));

            List<Models.BjoerkCurrencyExchange> currencyExchanges = new List<Models.BjoerkCurrencyExchange>();
            currencyExchanges.Add(new Models.BjoerkCurrencyExchange(currencies[0], currencies[1], 50.0M, (50.0M / currencies[1].ExchangeRate) * 100)); // calculation error
            currencyExchanges.Add(new Models.BjoerkCurrencyExchange(currencies[1], currencies[0], 10.0M, (10.0M / currencies[0].ExchangeRate) * 100)); // calculation error

            return View(currencyExchanges);
        }

        // GET: BjoerkCurrencyExchange/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BjoerkCurrencyExchange/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BjoerkCurrencyExchange/Create
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

        // GET: BjoerkCurrencyExchange/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BjoerkCurrencyExchange/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: BjoerkCurrencyExchange/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BjoerkCurrencyExchange/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
