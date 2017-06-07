using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class CurrencyData
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Para Birimi")]
        public string CurrencyName { get; set; }

        [DisplayName("Alış Fiyatı")]
        public string BanknoteBuying { get; set; }

        [DisplayName("Satış Fiyatı")]
        public string BanknoteSelling { get; set; }

        [DisplayName("Tarih")]
        public DateTime Date { get; set; }
    }
}
