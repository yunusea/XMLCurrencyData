using Models;
using Models.Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    public class GetData
    {
        public static void Run()
        {
            //DataContext _context = new DataContext();
            CurrencyDataService _service = new CurrencyDataService();

            XmlTextReader oku = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            try
            {
                int i = 0;

                Console.WriteLine(Convert.ToString(DateTime.Now));
                Console.WriteLine("--------------");

                List<CurrencyData> currencyDataList = new List<CurrencyData>();
               

                var data = new CurrencyData();

                while (oku.Read())
                {
                    if (i < 12)
                    {
                        if (oku.NodeType == XmlNodeType.Element)
                        {
                            switch (oku.Name)
                            {
                                case "Isim":
                                    var _currencyName = Convert.ToString(oku.ReadString());
                                    Console.WriteLine(_currencyName);
                                    data.CurrencyName = _currencyName;
                                    data.Date = DateTime.Now;
                                    break;
                                case "BanknoteBuying":
                                    var _banknoteBuying = Convert.ToString(oku.ReadString());
                                    Console.WriteLine(_banknoteBuying);
                                    data.BanknoteBuying = _banknoteBuying;
                                    break;
                                case "BanknoteSelling":
                                    var _banknoteSelling = Convert.ToString(oku.ReadString());
                                    Console.WriteLine(_banknoteSelling);
                                    data.BanknoteSelling = _banknoteSelling;
                                    Console.WriteLine("--------------");
                                    currencyDataList.Add(data);
                                    data = new CurrencyData();
                                    i++;
                                    break;
                            }

                        }

                    }
                    else
                    {
                        break;
                    }



                }

                using (var service = new CurrencyDataService())
                {
                    foreach (var item in currencyDataList)
                    {

                        service.Insert(item);
                    }
                }

                oku.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xml Bağlantı Hatası : " + ex.Message);
            }
        }
    }
}
