﻿using HealthAndFinance.Business.Abstract;
using HealthAndFinance.DataAccess.Abstract;
using HealthAndFinance.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Business.Concrete
{
    public class UserManager: IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public AppUser GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(AppUser t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            _userDal.Update(t);
        }
    }
}
