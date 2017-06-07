using Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork
    {
        private readonly ProjectDbContext _context = new ProjectDbContext();

        private CurrencyRepository _currencyRepository;

        public CurrencyRepository CurrencyRepository
        {
            get
            {
                return _currencyRepository ?? (_currencyRepository = new CurrencyRepository());
            }
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
