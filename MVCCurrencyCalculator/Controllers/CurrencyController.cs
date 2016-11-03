using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCurrencyCalculator.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: Currency
        [HttpGet]
        public ActionResult Index()
        {
            Models.CurrencyModel model = new Models.CurrencyModel();
            model.Userinput = string.Empty;
            model.Result = string.Empty;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string submit, Models.CurrencyModel model)
        {
            string res = string.Empty;
            if (model.Userinput == null)
                model.Userinput = string.Empty;
            switch (submit)
            {
                case "Convert from kr to euro":
                    decimal tempResult;
                    tempResult = Convert.ToDecimal(model.Userinput) / 745.99M * 100;
                    res = tempResult.ToString();
                    break;

                case "Get exchange rate":
                    switch (model.Userinput)
                    {
                        case "USD": res = "524.02"; break;
                        case "CAD": res = "492.27"; break;
                        case "EUR": res = "745.99"; break;
                        case "NOK": res = "90.34"; break;
                        case "GBP": res = "947.53"; break;
                        case "SEK": res = "78.21"; break;
                        default: res = "Unknown currency"; break;
                    }
                    break;

                default:
                    return new HttpStatusCodeResult
                    (System.Net.HttpStatusCode.NotImplemented,
                    this.ToString() + " does not have a " + submit + " function implemented.");
            }
            model.Result = res;
            ModelState.Remove("Result");
            return View(model);
        }
    }
}