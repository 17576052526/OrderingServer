using Common;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.DAL
{
    public class OrderDAL
    {
        /// <summary>
        /// 新增订单   
        /// </summary>
        /// <returns></returns>
        public int Insert(Order model)
        {
            throw new Exception("此方法还没写");
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        public List<Order> Select(string where = null, object param = null)
        {
            //数据库先根据所有要的订单查询订单详情，返回结果集，C#对结果集进行分组 构造 Order实体类， Order实体类包含了List<OrderDtl>

            throw new Exception("此方法还没写");
        }
    }
}
