using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public abstract class DataStoreBase
    {
        public abstract Story GetStory(Guid guid);
    }
}