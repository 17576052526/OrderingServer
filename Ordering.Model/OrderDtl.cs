using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Model
{
    public class OrderDtl
    {
        public int ID { set; get; }
        public int OrderID { set; get; }
        public int OrderingID { set; get; }
        public decimal Price { set; get; }
        public int Num { set; get; }

        /// <summary>
        /// 所属订单的单号
        /// </summary>
        public string OddNumber { set; get; }
    }
}
