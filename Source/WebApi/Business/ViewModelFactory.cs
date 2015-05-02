using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Business
{
    public static class ViewModelFactory
    {
        public static StoryViewModel Get(Story story)
        {
            return new StoryViewModel()
            {
                ParentStory = story.ParentStory,
                StoryGuid = story.StoryGuid,
                NorthStoryGuid = story.NorthStoryGuid,
                WestStoryGuid = story.WestStoryGuid,
                EastStoryGuid = story.EastStoryGuid,
                SouthStoryGuid = story.SouthStoryGuid,
                Keywords = story.Keywords,
                Title = story.Title,
                Story = story.StoryText,
                Author = story.Author,
                UpVoteCount = story.UpVotedBy != null ? story.UpVotedBy.Count() : 0,
                DownVoteCount = story.DownVotedBy != null ? story.DownVotedBy.Count() : 0
            };
        }
    }
}