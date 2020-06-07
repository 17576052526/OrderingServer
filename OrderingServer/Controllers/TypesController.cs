using Ordering.DAL;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderingServer.Controllers
{
    public class TypesController : ApiController
    {
        public List<Types> Get()
        {
            TypesDAL dal = new TypesDAL();
            return dal.Select();
        }
    }
}
