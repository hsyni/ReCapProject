using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAllImages()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<CarImage> GetCarImage(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarId == id));
        }

        public IResult Insert(CarImage carImage)
        {
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }
    }
}
