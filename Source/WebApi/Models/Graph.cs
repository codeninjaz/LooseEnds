using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Graph
    {
        public Graph North { get; set; }
        public Graph South { get; set; }
        public Graph West { get; set; }
        public Graph East { get; set; }
    }
}