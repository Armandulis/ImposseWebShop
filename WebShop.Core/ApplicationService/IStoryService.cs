using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public interface IStoryService
    {
        //  Crud

        //create
        Story CreateStory(Story story);

        //read
        Story GetStory(int id);
        List<Story> GetAllStories(Filter filter = null);

        //update
        Story UpdateStory(Story story);

        //delete
        Story DeleteStory(int id);

    }
}
