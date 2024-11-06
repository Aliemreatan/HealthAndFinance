using HealthAndFinance.Business.Abstract;
using HealthAndFinance.DataAccess.Abstract;
using HealthAndFinance.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Business.Concrete
{
    public class HealthEntryManager : IHealthEntryService
    {
        IHealthEntryDal _hDal;

        public HealthEntryManager(IHealthEntryDal hDal)
        {
            _hDal = hDal;
        }

        public HealthEntry GetById(int id)
        {
            return _hDal.GetById(id);
        }

        public List<HealthEntry> GetList()
        {
            return _hDal.GetListAll();
        }

        public void TAdd(HealthEntry t)
        {
            _hDal.Insert(t);
        }

        public void TDelete(HealthEntry t)
        {
            _hDal.Delete(t);
        }

        public void TUpdate(HealthEntry t)
        {
            _hDal.Update(t);
        }
    }
}
