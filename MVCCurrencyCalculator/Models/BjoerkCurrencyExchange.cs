using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCurrencyCalculator.Models
{
    public class BjoerkCurrencyExchange
    {
        //public string ISOFrom { get; set; }
        //public string ISOTo { get; set; }
        //public decimal ExchangeRateTo { get; set; }
        public BjoerkCurrency CurrencyFrom { get; set; }
        public BjoerkCurrency CurrencyTo { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }

        public BjoerkCurrencyExchange(BjoerkCurrency currencyFrom, BjoerkCurrency currencyTo, decimal amountFrom, decimal amountTo)
        {
            CurrencyFrom = currencyFrom;
            CurrencyTo = currencyTo;
            AmountFrom = amountFrom;
            AmountTo = amountTo;
        }
    }
}