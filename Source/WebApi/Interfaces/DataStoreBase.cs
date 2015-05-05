using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public abstract class DataStoreBase
    {
        public abstract StoryBase Story { get; set; }

        public abstract StoriesBase Stories { get; set; }
    }
}