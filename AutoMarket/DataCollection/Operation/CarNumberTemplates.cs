using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AutoMarket
{
    class CarNumberTemplates
    {      
      public List<NumberTemplates> numberTemplates;      

      public CarNumberTemplates()
        {
            this.numberTemplates = new List<NumberTemplates>() { 
                new NumberTemplates {Pattern = @"[A-Z]{2}\d{3}[A-Z]{1}"},
                new NumberTemplates {Pattern = @"[A-Z]{2}\d{4}[A-Z]{2}\d{1}"},
                new NumberTemplates {Pattern = @"\d{3}[A-Z]{1}"}
            };
        }

        public bool CheckingCompliance(string carNumber)
        {
           return CheckingCompliance(carNumber, numberTemplates);
        }

        private bool CheckingCompliance(string carNumber, List<NumberTemplates> numberTemplates)
        {         
            Regex re = new Regex(carNumber, RegexOptions.IgnoreCase);
            bool result = numberTemplates.Any(n => new Regex(n.Pattern, RegexOptions.IgnoreCase).IsMatch(carNumber));                  

            return result;
        }
    }
}
