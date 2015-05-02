using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Business
{
    public class SqlStore : DataStoreBase
    {
        public override Story GetStory(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}