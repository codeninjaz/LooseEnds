using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class StoriesViewModel
    {
        public Guid StoryGuid { get; set; }

        public Guid NorthStoryGuid { get; set; }

        public Guid WestStoryGuid { get; set; }
        public Guid EastStoryGuid { get; set; }
        public Guid SouthStoryGuid { get; set; }

        public string Title { get; set; }

        public string StoryText { get; set; }

        public int NumberOfStories { get; set; }

        public DateTime LastActivity { get; set; }

        public GraphRootViewModel GraphRoot { get; set; }
    }
}