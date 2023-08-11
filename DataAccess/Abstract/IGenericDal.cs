using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T:class
    {

        List<T> GetList();
        List<T> GetListAll(Expression<Func<T,bool>>filter);
        T GetById(int id);
        void Insert(T t);
        void Delete(T t);
        void Update(T t);


    }
}
