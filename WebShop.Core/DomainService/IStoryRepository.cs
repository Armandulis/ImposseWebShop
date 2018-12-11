using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.DomainService
{
    public interface IStoryRepository
    {
        //CRUD

        //Create
        Story CreateStory(Story story);

        //Read
        Story GetStory(int id);
        IEnumerable<Story> GetAllStories(Filter filter = null);

        //Update
        Story UpdateStory(Story story);

        //Delete
        Story DeleteStory(int id);


        
    }
}
