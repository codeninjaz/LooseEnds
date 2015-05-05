using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public abstract class StoriesBase
    {
        public abstract List<Stories> Top(int value);

        public abstract GraphRoot Graph(Guid value);
    }
}