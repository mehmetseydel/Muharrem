using DataAccess.Abstract;
using DataAccess.Repository;
using EntityLayer.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfServiceDal:GenericRepository<Service>, IServiceDal
    {
    }
}
