using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public abstract class StoryBase
    {
        public abstract Story Get(Guid guid);
    }
}