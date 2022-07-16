using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}

//carManager.Insert(new Car() { Description = "Two accident", BrandId = 1, ColorId = 2, DailyPrice = 7500, ModelYear = 2019, Id = 4 });

//carManager.Delete(new Car() { Id = 4 });

//var car = carManager.GetById(1);
//Console.WriteLine(car.Description);

//BrandManager brandManager = new BrandManager(new EfBrandDal());

//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.Name);
//}

foreach (var car in carManager.GetCarDetail())
{
    Console.WriteLine(car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
}