using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace FinanceApp.IDAL
{
    public interface IBaseDAL<T>
    {
        DbContext CurrentContext { get; }

        T Add(T entity);

        int Count(Expression<Func<T, bool>> predicate);

        bool Update(T entity);

        bool Invalid(T entity);

        bool Exist(Expression<Func<T, bool>> predicate);

        T Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> Load(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda);

        IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord,
            Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda);

    }
}
