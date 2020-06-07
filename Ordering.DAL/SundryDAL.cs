using Common;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.DAL
{
    public class SundryDAL
    {
        /// <summary>
        /// 查询数据
        /// </summary>
        public List<Sundry> Select(string where = null, object param = null, int? top = null)
        {
            string sql = "select " + (top != null ? "top " + top : null) + " * from Sundry " + (!String.IsNullOrEmpty(where) ? "where " + where : null);
            return DbHelper.Select<Sundry>(sql, param);
        }
    }
}
