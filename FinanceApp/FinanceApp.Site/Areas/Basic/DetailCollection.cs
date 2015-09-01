using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FinanceApp.Model;

namespace FinanceApp.Site.Areas.Basic
{
    public class DetailCollection : ICollection<BDStyleDetail>
    {
        readonly List<BDStyleDetail> details = new List<BDStyleDetail>();

        /// <summary>
        /// 通过DetailCode获取NFMT.Data.Model.BDStyleDetail对象
        /// </summary>
        /// <param name="detailCode"></param>
        /// <returns></returns>
        public BDStyleDetail this[string detailCode]
        {
            get { return details.FirstOrDefault(detail => detail.DetailCode == detailCode); }
        }

        /// <summary>
        /// 通过DetailId获取NFMT.Data.Model.BDStyleDetail对象
        /// </summary>
        /// <param name="detailId"></param>
        /// <returns></returns>
        public BDStyleDetail this[int detailId]
        {
            get { return details.FirstOrDefault(detail => detail.StyleDetailId == detailId); }
        }
        /// <summary>
        /// 添加NFMT.Data.Model.BDStyleDetail对象至集合中
        /// </summary>
        /// <param name="item"></param>
        public void Add(BDStyleDetail item)
        {
            details.Add(item);
        }

        /// <summary>
        /// 清除集合所有包含的NFMT.Data.Model.BDStyleDetail
        /// </summary>
        public void Clear()
        {
            details.Clear();
        }

        public bool Contains(BDStyleDetail item)
        {
            return details.Contains(item);
        }

        public void CopyTo(BDStyleDetail[] array, int arrayIndex)
        {
            details.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return details.Count; }
        }

        bool ICollection<BDStyleDetail>.IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(BDStyleDetail item)
        {
            return details.Remove(item);
        }

        public IEnumerator<BDStyleDetail> GetEnumerator()
        {
            return details.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return details.GetEnumerator();
        }
    }
}
