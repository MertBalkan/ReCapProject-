using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Car : IEntity
    {
        private int _id;
        private int _brandId;
        private int _colorId;
        private string _modelYear;
        private decimal _dailyPrice;
        private string _description;

        public int Id { get => _id; set => _id = value; }
        public int BrandId { get => _brandId; set => _brandId = value; }
        public int ColorId { get => _colorId; set => _colorId = value; }
        public string ModelYear { get => _modelYear; set => _modelYear = value; }
        public decimal DailyPrice { get => _dailyPrice; set => _dailyPrice = value; }
        public string Description { get => _description; set => _description = value; }
    }
}