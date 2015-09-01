using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using FinanceApp.IDAL;

namespace FinanceApp.DAL
{
    public abstract class BaseDAL<T> : IBaseDAL<T> where T : class
    {
        /// <summary>
        /// 数据库上下文
        /// </summary>
        public abstract DbContext CurrentContext { get; }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Add(T entity)
        {
            CurrentContext.Entry<T>(entity).State = EntityState.Added;
            CurrentContext.SaveChanges();
            return entity;
        }

        /// <summary>
        /// 获取数量
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return CurrentContext.Set<T>().Count(predicate);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Update(T entity)
        {
            CurrentContext.Set<T>().Attach(entity);
            CurrentContext.Entry<T>(entity).State = EntityState.Modified;
            return CurrentContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 作废
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public abstract bool Invalid(T entity);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual bool Exist(Expression<Func<T, bool>> predicate)
        {
            return CurrentContext.Set<T>().Any(predicate);
        }

        /// <summary>
        /// 返回符合条件的单个model
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            return CurrentContext.Set<T>().FirstOrDefault<T>(predicate);
        }

        /// <summary>
        /// 返回符合条件的所有model
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Load(Expression<Func<T, bool>> predicate)
        {
            return CurrentContext.Set<T>().Where<T>(predicate);
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
