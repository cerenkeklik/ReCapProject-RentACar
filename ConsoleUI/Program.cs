using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
