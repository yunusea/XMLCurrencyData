using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.ViewModel
{
    public class CurrencyViewModel
    {
        public IEnumerable<CurrencyData> CurrencyList { get; set; }
        public CurrencyData CurrencyData { get; set; }
    }
}