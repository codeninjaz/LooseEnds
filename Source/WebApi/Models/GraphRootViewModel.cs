using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class GraphRootViewModel
    {
        public Guid StoryGuid { get; set; }

        public GraphViewModel Graph {get; set;}
    }
}