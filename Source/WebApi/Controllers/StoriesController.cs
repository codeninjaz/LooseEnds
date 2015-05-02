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
    public class StoriesController : ApiController
    {
        public List<StoriesViewModel> Get()
        {
            var stories = Store.Instance.Stories.Top(10);
            return ViewModelFactory.Get(stories);
        }
    }
}
