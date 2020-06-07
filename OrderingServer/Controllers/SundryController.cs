using Ordering.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderingServer.Controllers
{
    public class SundryController : ApiController
    {
        public List<Ordering.Model.Sundry> Get()
        {
            SundryDAL dal = new SundryDAL();
            return dal.Select();
        }
    }
}
