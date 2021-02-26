using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _productDal;
        public CarManager(ICarDal productDal)
        {
            _productDal = productDal;
        }


        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0) {
                _productDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _productDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _productDal.GetAll(c => c.ColorId == Id);
        }
    }
}
