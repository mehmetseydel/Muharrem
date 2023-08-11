using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PersonalManager : IPersonalService
    {
        IPersonalDal _personalDal;

        public PersonalManager(IPersonalDal personalDal)
        {
            _personalDal = personalDal;
        }

        public void TAdd(Personal t)
        {
            _personalDal.Insert(t);

        }

        public void TDelete(Personal t)
        {
            _personalDal.Delete(t);

        }

        public Personal TGetById(int id)
        {
            return _personalDal.GetById(id);

        }

        public List<Personal> TGetList()
        {
            return _personalDal.GetList();

        }

        public void TUpdate(Personal t)
        {
            _personalDal.Update(t);

        }
    }
}
