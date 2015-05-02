using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class StoryViewModel
    {

        public Guid ParentStory { get; set; }
        public Guid StoryGuid { get; set; }
        public Guid NorthStoryGuid { get; set; }

        public Guid WestStoryGuid { get; set; }
        public Guid EastStoryGuid { get; set; }
        public Guid SouthStoryGuid { get; set; }

        public String[] Keywords { get; set; }

        public string Title { get; set; }

        public string Story { get; set; }

        public string Author { get; set; }

        public int UpVoteCount { get; set; }

        public int DownVoteCount { get; set; }

    }
}