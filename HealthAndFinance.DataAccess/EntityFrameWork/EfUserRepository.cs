using HealthAndFinance.DataAccess.Abstract;
using HealthAndFinance.DataAccess.Repositiories;
using HealthAndFinance.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.DataAccess.EntityFrameWork
{
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
    }
}
