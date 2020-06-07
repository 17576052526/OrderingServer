using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Model
{
    public class Ordering
    {
        public int ID { set; get; }
        public int TypeID { set; get; }
        public string Name { set; get; }
        public string Img { set; get; }
        public decimal Price { set; get; }
        public string Desc { set; get; }
    }
}
