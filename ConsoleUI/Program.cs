using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //ColorManagerTest();
            BrandManagerTest();
            //CarDetailsTest();

        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.Description + " - " + item.BrandName + " - " + item.ColorName);
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand b = brandManager.GetById(12).Data;
            b.Name = "MINI";
            Console.WriteLine(brandManager.Update(b).Message);
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            // colorManager.Delete(colorManager.GetById(10));
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var c in carManager.GetAll())
            //{
            //    Console.WriteLine(c.Description);
            //}
             

        }
    }
}
