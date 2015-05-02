using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Business
{
    public class DummyStore : DataStoreBase
    {
        public override StoryBase Story
        {
            get
            {
                return new DummyStory();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public class DummyStory : StoryBase
    {
        public override Story Get(Guid guid)
        {
            return new Story()
            {
                StoryGuid = Guid.NewGuid(),
                Author = "Johan",
                DownVotedBy = new[] { "Anders", "Micke" },
                UpVotedBy = new[] { "Jesus" },
                EastStoryGuid = Guid.NewGuid(),
                WestStoryGuid = Guid.NewGuid(),
                NorthStoryGuid = Guid.NewGuid(),
                SouthStoryGuid = Guid.NewGuid(),
                Keywords = new[] { "Jebuz", "Hell" },
                ParentStory = Guid.NewGuid(),
                StoryText = "Storytext, lorem ipsum and so on",
                Title = "This Title is awesome!!!"
            };
        }
    }
}