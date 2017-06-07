using Models;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class CurrencyRepository : GenericRepository<CurrencyData>
    {
        public readonly UnitOfWork UnitOfWork = new UnitOfWork();
        private static readonly ProjectDbContext Context = new ProjectDbContext();

        public CurrencyRepository() : base(Context)
        {
        }
    }
}
