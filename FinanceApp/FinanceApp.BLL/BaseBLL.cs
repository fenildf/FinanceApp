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
        protected IDAL.IBaseDAL<T> CurDALInstance { get; set; }

        protected BaseBLL(IDAL.IBaseDAL<T> currentDAL)
        {
            CurDALInstance = currentDAL;
        }

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
