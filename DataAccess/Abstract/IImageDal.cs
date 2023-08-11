using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IImageDal :IGenericDal<Image>
    {
        public List<Image> GetImageWithImageCategory();
    }
}
