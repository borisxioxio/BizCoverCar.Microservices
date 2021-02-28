using Cars.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace CarsUnitTest
{
    [TestClass]
    public class CarsTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task GetAllCarsAsync()
        {
            List<BizCover.Repository.Cars.Car> cars = await BizCoverHelper.GetAllCars();
        }
    }
}
