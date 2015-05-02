using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class GraphViewModel
    {
        public GraphViewModel North { get; set; }
        public GraphViewModel South { get; set; }
        public GraphViewModel West { get; set; }
        public GraphViewModel East { get; set; }
    }
}