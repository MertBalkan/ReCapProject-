﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
