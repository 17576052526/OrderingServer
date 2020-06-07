using Common;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordering.Model;

namespace Ordering.DAL
{
    public class OrderingDAL
    {
        /// <summary>
        /// 查询数据
        /// </summary>
        public List<Ordering.Model.Ordering> Select(string where = null, object param = null, int? top = null)
        {
            string sql = "select " + (top != null ? "top " + top : null) + " * from Ordering " + (!String.IsNullOrEmpty(where) ? "where " + where : null);
            return DbHelper.Select<Ordering.Model.Ordering>(sql, param);
        }
    }
}
