using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=70, ModelYear=2014, Description="Mercedes" },
            new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=75, ModelYear=2012, Description="Skoda" },
            new Car{Id=3, BrandId=3, ColorId=1, DailyPrice=80, ModelYear=2018, Description="Fiat" },
            new Car{Id=4, BrandId=2, ColorId=3, DailyPrice=90, ModelYear=2019, Description="Tesla" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _cars.Single(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
