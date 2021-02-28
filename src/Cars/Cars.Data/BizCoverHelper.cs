using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BizCover;
using BizCover.Repository.Cars;

namespace Cars.Data
{
    public static class BizCoverHelper
    {
        public static BizCover.Repository.Cars.ICarRepository CarRepository => new BizCover.Repository.Cars.CarRepository();
    
        public async static Task<List<Car>> GetAllCars() => await CarRepository.GetAllCars();

        public async static Task UpdateCar(Car car) => await CarRepository.Update(car);

        public async static Task<int> AddCar(Car car) => await CarRepository.Add(car);
    }
}
