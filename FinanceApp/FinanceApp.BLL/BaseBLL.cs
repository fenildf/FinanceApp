using System;
using System.Linq.Expressions;
using FinanceApp.DAL;
using log4net;

namespace FinanceApp.BLL
{
    public abstract class BaseBLL<T> where T : class
    {
        protected ILog log = LogManager.GetLogger(typeof(BaseBLL<T>));

        protected  abstract BaseDAL<T> CurDALInstance { get; }

        protected virtual T Add(T entity)
        {
            return CurDALInstance.Add(entity);
        }

        protected virtual bool Update(T entity)
        {
            return CurDALInstance.Update(entity);
        }

        protected virtual T Find(Expression<Func<T, bool>> whereLambda)
        {
            return CurDALInstance.Find(whereLambda);
        }
    }
}
