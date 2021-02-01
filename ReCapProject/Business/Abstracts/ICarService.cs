using Entities.Concretes;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface ICarService
    {
        List<Car> GetCars();
    }
}