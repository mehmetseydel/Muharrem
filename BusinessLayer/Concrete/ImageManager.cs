using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void TAdd(Image t)
        {
            _imageDal.Insert(t);

        }

        public void TDelete(Image t)
        {
            _imageDal.Delete(t);

        }

        public Image TGetById(int id)
        {
            return _imageDal.GetById(id);

        }

        public List<Image> TGetImageWithImageCategory()
        {
            return _imageDal.GetImageWithImageCategory();
        }

        public List<Image> TGetList()
        {
            return _imageDal.GetList();

        }

        public void TUpdate(Image t)
        {
            _imageDal.Update(t);

        }
    }
}
