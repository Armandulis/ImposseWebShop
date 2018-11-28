using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService.Services
{
    public class StoryService : IStoryService
    {

        readonly IStoryRepository _Repo;


        //Dependancy Injection
        public StoryService(IStoryRepository repo)
        {
            _Repo = repo;

        }

        //Create
        public Story CreateStory(Story story)
        {
            return _Repo.CreateStory(story);
        }


        //Delete
        public Story DeleteStory(int id)
        {
            return _Repo.DeleteStory(id);
        }


        //Read
        public IEnumerable<Story> GetAllStories()
        {
            return _Repo.GetAllStories().ToList();
        }

        public Story GetStory(int id)
        {
            return _Repo.GetStory(id);
        }


        //Update
        public Story UpdateStory(Story story)
        {
           return _Repo.UpdateStory(story);
        }
    }
}
