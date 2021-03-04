using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == default(DateTime));
            if (result.Count==0)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Successful);
            }
            return new ErrorResult(Messages.CannotChooseCar);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Successful);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());      
         }

        public IDataResult<Rental> GetByCarId(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == Id));
        }

        public IDataResult<Rental> GetByCustomerId(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CustomerId == Id));
        }

        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == Id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Successful);
        }
    }
}
