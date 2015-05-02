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
                DownVoteCount = story.DownVotedBy != null ? story.DownVotedBy.Count() : 0,
                Published = story.Published
            };
        }

        public static List<StoriesViewModel> Get(List<Stories> stories)
        {
            var listOfStories = new List<StoriesViewModel>();
            foreach(var item in stories)
            {
                var svm = new StoriesViewModel()
                {
                    StoryGuid = item.StoryGuid,
                    EastStoryGuid = item.EastStoryGuid,
                    WestStoryGuid = item.WestStoryGuid,
                    NorthStoryGuid = item.NorthStoryGuid,
                    LastActivity = item.LastActivity,
                    NumberOfStories = item.NumberOfStories,
                    SouthStoryGuid = item.SouthStoryGuid,
                    StoryText = item.StoryText,
                    Title = item.StoryText
                };

                listOfStories.Add(svm);
            }

            return listOfStories;
        }
    }
}