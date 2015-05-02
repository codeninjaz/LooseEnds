using FizzWare.NBuilder;
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
        public override StoriesBase Stories
        {
            get
            {
                return new DummyStories();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

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
            return Builder<Story>.CreateNew().With(x => x.Title = "Dummytitle").Build();
        }
    }

    public class DummyStories : StoriesBase
    {
        public override GraphRoot Graph(Guid value)
        {
            return Builder<GraphRoot>.CreateNew().Build();
        }

        public override List<Stories> Top(int value)
        {
            return Builder<Stories>.CreateListOfSize(value).All().With(x => x.Title = "Dummytitle").Build().ToList();
        }
    }
}