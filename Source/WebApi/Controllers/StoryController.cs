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
    public class StoryController : ApiController
    {        
        public StoryViewModel Get(Guid guid)
        {
            var story = Store.Instance.Story.Get(guid);
            if (story == null) throw new HttpResponseException(HttpStatusCode.NotFound);

            return ViewModelFactory.Get(story);
        }
    }
}
