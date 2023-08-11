using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ImageCategoryManager : IImageCategoryService
    {
        IImageCategoryDal _ImageCategoryDal;

        public ImageCategoryManager(IImageCategoryDal imageCategoryDal)
        {
            _ImageCategoryDal = imageCategoryDal;
        }

        public void TAdd(ImageCategory t)
        {
            _ImageCategoryDal.Insert(t);

        }

        public void TDelete(ImageCategory t)
        {
            _ImageCategoryDal.Delete(t);

        }

        public ImageCategory TGetById(int id)
        {
            return _ImageCategoryDal.GetById(id);

        }

        public List<ImageCategory> TGetList()
        {
            return _ImageCategoryDal.GetList();

        }

        public void TUpdate(ImageCategory t)
        {
            _ImageCategoryDal.Update(t);
        }
    }
}
