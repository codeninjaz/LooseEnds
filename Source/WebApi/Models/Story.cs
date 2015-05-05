using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Story
    {
        public Guid ParentStory { get; set; }
        public Guid StoryGuid { get; set; }
        public Guid NorthStoryGuid { get; set; }

        public Guid WestStoryGuid { get; set; }
        public Guid EastStoryGuid { get; set; }
        public Guid SouthStoryGuid { get; set; }

        public String[] Keywords { get; set; }

        public string Title { get; set; }

        public string StoryText { get; set; }

        public string Author { get; set; }

        public DateTime Published { get; set; }

        public string[] UpVotedBy { get; set; }

        public string[] DownVotedBy { get; set; }
    }
}