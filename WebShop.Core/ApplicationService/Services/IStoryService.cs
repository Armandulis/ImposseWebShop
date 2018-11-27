﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService.Services
{
    public interface IStoryService
    {
        //  Crud

        //create
        Story CreateStory(Story story);

        //read
        Story GetStory(int id);
        IEnumerable<Story> GetAllStories();

        //update
        Story UpdateStory(Story story);

        //delete
        Story DeleteStory(int id);

    }
}
