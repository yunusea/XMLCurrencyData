using Models.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CurrencyDataService : IDisposable
    {
        public readonly UnitOfWork UnitOfWork = new UnitOfWork();
        
        public IEnumerable<CurrencyData> GetAllCurrencyData()
        {
            return UnitOfWork.CurrencyRepository.GetAll();
        }

        public CurrencyData GetById(int Id)
        {
            return UnitOfWork.CurrencyRepository.GetById(Id);
        }

        public CurrencyData Insert(CurrencyData model)
        {
            var entity = new CurrencyData
            {
                CurrencyName = model.CurrencyName != null ? model.CurrencyName : "Para Birimi Bulunamadı !",
                BanknoteBuying = model.BanknoteBuying != null ? model.BanknoteBuying : "Banknot Alış Değeri Bulunamadı !",
                BanknoteSelling = model.BanknoteSelling != null ? model.BanknoteSelling : "Banknot Satış Değeri Bulunamadı !",
                Date = model.Date != null ? model.Date : DateTime.Now
            };

            UnitOfWork.CurrencyRepository.Insert(entity);
            return model;
        }

        public CurrencyData Update(CurrencyData model)
        {
            var entity = new CurrencyData
            {
                Id = model.Id,
                CurrencyName = model.CurrencyName != null ? model.CurrencyName : "Para Birimi Bulunamadı !",
                BanknoteBuying = model.BanknoteBuying != null ? model.BanknoteBuying : "Banknot Alış Değeri Bulunamadı !",
                BanknoteSelling = model.BanknoteSelling != null ? model.BanknoteSelling : "Banknot Satış Değeri Bulunamadı !",
                Date = model.Date != null ? model.Date : DateTime.Now
            };

            UnitOfWork.CurrencyRepository.Update(entity);
            return model;
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }

    }
}
