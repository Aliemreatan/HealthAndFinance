using HealthAndFinance.DataAccess.Abstract;
using HealthAndFinance.DataAccess.Concrete;
using HealthAndFinance.DataAccess.Repositiories;
using HealthAndFinance.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.DataAccess.EntityFrameWork
{
    public class EfHealthEntryRepository : GenericRepository<HealthEntry>, IHealthEntryDal
    {
        public List<HealthEntry> GetListWithUser(int id)
        {
            using (var c = new Context())
            {
                return c.HealthEntries.Include(h => h.User).ToList();
            }
        }
    }
}
