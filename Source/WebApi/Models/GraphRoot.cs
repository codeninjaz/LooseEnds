using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class GraphRoot
    {
        public Guid StoryGuid { get; set; }

        public Graph Graph { get; set; }
    }
}