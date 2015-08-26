using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.BLL
{
    public abstract class BaseBLL<T>
    {
        protected IDAL.IBaseDAL<T> DALInstance { get; set; }

        protected BaseBLL(IDAL.IBaseDAL<T> currentDAL)
        {
            DALInstance = currentDAL;
        }

        protected virtual T Add(T entity)
        {
            return DALInstance.Add(entity);
        }

        protected virtual bool Update(T entity)
        {
            return DALInstance.Update(entity);
        }

        protected virtual T Find(Expression<Func<T, bool>> whereLambda)
        {
            return DALInstance.Find(whereLambda);
        }
    }
}
