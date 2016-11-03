using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCurrencyCalculator.Models
{
    public class CurrencyModel
    {
        //[StringLength(8, ErrorMessage = "Input can't be longer than 8 characters. This is just a datanotation test.")]
        private string userinput;
        public string Userinput
        {
            get { return userinput; }
            set
            {
                //Validator.ValidateProperty(value, new ValidationContext(this));
                //Validator.ValidatesOnExceptions = true;
                //Validator.NotifyOnValidationError = true;
                userinput = value;
            }
        }
        public string Result { get; set; }
    }
}