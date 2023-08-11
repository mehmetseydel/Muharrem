using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IImageService:IGenericService<Image>
    {
        List<Image> TGetImageWithImageCategory();

    }
}
