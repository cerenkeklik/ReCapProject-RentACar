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
            //BrandManagerTest();
            //CarDetailsTest();
            //AddingUser();
            //AddingCustomer();
            //AddingRental();

        }

        private static void AddingRental()
        {
            Rental rent = new Rental();
            rent.Id = 9;
            rent.CarId = 5;
            rent.CustomerId = 1;
            rent.RentDate = DateTime.Now;
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(rent).Message);
        }

        private static void AddingCustomer()
        {
            Customer customer = new Customer();
            customer.Id = 9;
            customer.UserId = 11;
            customer.CompanyName = "CerenAŞ";
            Customer customer1 = new Customer();
            customer1.UserId = 11;
            customer1.Id = 10;
            customer1.CompanyName = "SABANCI";
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(customer).Message);
            Console.WriteLine(customerManager.Add(customer1).Message);
        }

        private static void AddingUser()
        {
            User user = new User();
            user.Id = 11;
            user.FirstName = "Ceren";
            user.LastName = "Keklik";
            user.Email = "cerenkeklik67@hotmail.com";
            user.Password = "1234";
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine(userManager.Add(user).Message);
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
