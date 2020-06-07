using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Model
{
    public class Order
    {
        public int ID { set; get; }
        public string OddNumber { set; get; }
        public DateTime Dates { set; get; }
        public string Address { set; get; }
        public int UserID { set; get; }
        public int TotalNum { set; get; }
        public decimal TotalPrice { set; get; }
        public int State { set; get; }
        public List<OrderDtl> OrderDtl { set; get; }
    }
}
