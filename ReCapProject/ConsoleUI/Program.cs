using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.Memory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDal carDal = new InMemoryDal();
            CarManager carManager = new CarManager(carDal);

            var cars = carManager.GetCars();

            foreach (var car in cars)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
