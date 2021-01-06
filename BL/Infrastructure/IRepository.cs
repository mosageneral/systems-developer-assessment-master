
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BL.Infrastructure
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where);
        T GetById(params object[] id);
        void Add(T entity);
        void Update(T entity);
        void Delete(params object[] id);

    }
}