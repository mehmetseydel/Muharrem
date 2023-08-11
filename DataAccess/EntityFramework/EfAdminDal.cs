using DataAccess.Abstract;
using DataAccess.Repository;
using EntityLayer.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>,IAdminDal
    {

    }
}
