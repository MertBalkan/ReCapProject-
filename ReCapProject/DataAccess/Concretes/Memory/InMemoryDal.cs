using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concretes.Memory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> cars;
        public InMemoryDal()
        {
            cars = new List<Car> 
            { 
                //1-> Black, 2-> Red, 3->Green, 4-> Blue
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "Toyota1", ModelYear = "2016"}, 
                new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 500, Description = "Toyota2", ModelYear = "2017"},
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Hyundai1", ModelYear = "2015"}, 
                new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 100, Description = "Volksvogen1", ModelYear = "2011"}, 
                new Car { Id = 5, BrandId = 4, ColorId = 4, DailyPrice = 400, Description = "Volvo1", ModelYear = "2015"}, 
                new Car { Id = 6, BrandId = 4, ColorId = 2, DailyPrice = 600, Description = "Volvo2", ModelYear = "2020"}, 
            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedCar = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(deletedCar);
        }
        public void Update(Car car)
        {
            var updatedCar = cars.SingleOrDefault(c => c.Id == car.Id);
            
            car.Id = updatedCar.Id;
            car.BrandId = updatedCar.BrandId;
            car.ColorId = updatedCar.ColorId;
            car.DailyPrice = updatedCar.DailyPrice;
            car.Description = updatedCar.Description;
            car.ModelYear = updatedCar.ModelYear;
        }
        public List<Car> GetAll()
        {
            return cars;            
        }

        public List<Car> GetById(int id)
        {
            var getCarById = cars.Where(c => c.Id == id).ToList();
            return getCarById;
        }
    }
}