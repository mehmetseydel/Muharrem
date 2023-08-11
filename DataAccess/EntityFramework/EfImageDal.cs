using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.EntityFramework
{
    public class EfImageDal : GenericRepository<Image>, IImageDal
    {
        public List<Image> GetImageWithImageCategory()
        {
            using (var c= new Context())
            {
                return c.Images.Include(x => x.ImageCategory).ToList();
            }
        }
    }
}
