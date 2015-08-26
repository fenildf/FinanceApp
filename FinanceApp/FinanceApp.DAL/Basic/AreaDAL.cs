using System;
using System.Data.Entity;
using FinanceApp.IDAL;
using FinanceApp.Model;

namespace FinanceApp.DAL
{
    public class AreaDAL : BaseDAL<Area>,IAreaDAL
    {
        public override DbContext CurrentContext
        {
            get { throw new NotImplementedException(); }
        }

        public override bool Invalid(Area entity)
        {
            throw new NotImplementedException();
        }
    }
}
