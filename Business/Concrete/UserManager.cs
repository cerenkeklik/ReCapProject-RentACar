using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
        }


        public IResult Add(User user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.Successful);
        }

        public User GetByMail(string Email)
        {
            return _userdal.Get(u => u.Email == Email);
            
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user) ;
        }


        public IResult Delete(User user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.Successful);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll());
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userdal.Get(u => u.Id == Id));
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.Successful);
        }
    }
}
