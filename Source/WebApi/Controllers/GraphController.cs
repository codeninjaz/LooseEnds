using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Business;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class GraphController : ApiController
    {
        public GraphRootViewModel Get(Guid guid)
        {
            var graph = Store.Instance.Stories.Graph(guid);
            return ViewModelFactory.Get(graph);
        }
    }
}
