using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using FinanceApp.IDAL;

namespace FinanceApp.BLL
{
    public abstract class BaseBLL<T> : IBaseDAL<T> where T : class
    {
        public abstract DbContext CurrentContext { get; }

        public virtual T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Invalid(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Exist(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda)
        {
            throw new NotImplementedException();
        }
    }
}
