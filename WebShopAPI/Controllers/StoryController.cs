using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.ApplicationService;
using WebShop.Core.ApplicationService.Services;
using WebShop.Core.Entity;

namespace WebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {

        readonly IStoryService _storyService;

        public StoryController(IStoryService storyService)
        {
            _storyService = storyService;
        }

        // GET: api/Story
        [HttpGet]
        public IEnumerable<Story> Get()
        {
            return _storyService.GetAllStories();
        }

        // GET: api/Story/5
        [HttpGet("{id}", Name = "GetStory")]
        public ActionResult<Story> Get(int id)
        {

            if (id < 1) return BadRequest("Id must be greater then 0");
            else return _storyService.GetStory(id);
        }

        // POST: api/Story
        [HttpPost]
        public ActionResult<Story> Post([FromBody] Story story)
        {
            Story storythis = _storyService.CreateStory(story);

            if (story.Text != null && story.Text != "") return Ok(storythis);
            else return BadRequest("Story has to have Text in it");
        }

        // PUT: api/Story/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Story story)
        {
            if (id != story.Id)
            {
                return BadRequest();
            }
            if (_storyService.UpdateStory(story) != null) return Ok($"Story {story.Id} was Deleted");
            else return BadRequest("There is no story with such id");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Story> Delete(int id)
        {
            if (_storyService.DeleteStory(id) != null) return Ok($"Story with Id: {id} is Deleted");
            else return BadRequest("There is no story with such id");

        }
    }
}
