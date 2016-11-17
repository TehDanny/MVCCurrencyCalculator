using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCurrencyCalculator.Models
{
    public class BjoerkCurrency
    {
        [Display(Name="Currency code")]
        [Required(ErrorMessage = "Please write a currency code")]
        [RegularExpression(@"^[A-Z]{3}$", ErrorMessage = "The currency code must be 3 letters long")]
        public string ISO { get; set; }

        [Display(Name = "Currency")]
        [Required(ErrorMessage = "Please write a currency")]
        public string Name { get; set; }

        [Display(Name = "Exchange rate")]
        [Required(ErrorMessage = "Please write an exchange rate")]
        [Range(0.0001, 1000000.00, ErrorMessage = "The exchange rate must be between 0.0001 and 1000000.00")]
        public decimal ExchangeRate { get; set; }

        public BjoerkCurrency(string iso, string name, decimal exchangeRate)
        {
            ISO = iso;
            Name = name;
            ExchangeRate = exchangeRate;
        }

        public BjoerkCurrency() : this("", "", 0.00M)
        {

        }
    }
}