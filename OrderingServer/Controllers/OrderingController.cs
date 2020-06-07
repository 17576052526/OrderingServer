using Ordering.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderingServer.Controllers
{
    public class OrderingController : ApiController
    {
        public List<Ordering.Model.Ordering> Get()
        {
            OrderingDAL dal = new OrderingDAL();
            return dal.Select();
        }
    }
}
