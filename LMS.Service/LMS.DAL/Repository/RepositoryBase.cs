using LMS.DALL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LMS.DALL.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected LMSContext _lMSContext { get; set; }

        public RepositoryBase(LMSContext lMSContext)
        {
            this._lMSContext = lMSContext;
        }

        public IEnumerable<T> FindAll()
        {
            return this._lMSContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._lMSContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this._lMSContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this._lMSContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this._lMSContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this._lMSContext.SaveChanges();
        }
    }
}
