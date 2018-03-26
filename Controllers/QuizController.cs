using System;
using System.Collections.Generic;
using System.Linq;
using core2angular5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core2angular5.Controllers
{
    [Produces("application/json")]
    [Route("api/Quiz")]
    public class QuizController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var element = new QuizViewModel()
            {
                Id = id,
                Title = $"Quiz{id}",
                Description = $"Description{id}",
                CreateDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            };

            return new JsonResult(element, new JsonSerializerSettings(){Formatting = Formatting.Indented});
        }

        [HttpGet("Latest/{num}")]
        public IActionResult Latest(int num = 10)
        {
            var sampleQuizzes = new List<QuizViewModel>
            {
                new QuizViewModel()
                {
                    Id = 1,
                    Title = "Title001",
                    Description = "Description001",
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }
            };


            for (var i = 2; i <= num; i++)
            {
                sampleQuizzes.Add(new QuizViewModel()
                {
                    Id = i,
                    Title = string.Format("Quiz {0}",i),
                    Description = string.Format("Description {0}",i),
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }


            return new JsonResult(sampleQuizzes, new JsonSerializerSettings(){Formatting = Formatting.Indented});
        }

        [HttpGet("ByTitle/{num:int?}")]
        public IActionResult ByTitle(int num = 10)
        {
            var sampleQuizzes = ((JsonResult) Latest(num)).Value as List<QuizViewModel>;
            return new JsonResult(sampleQuizzes.OrderBy(t=>t.Title), new JsonSerializerSettings(){Formatting = Formatting.Indented});
        }

        [HttpGet("Random/{num:int?}")]
        public IActionResult Random(int num = 10)
        {
            var sampleQuizzes = ((JsonResult) Latest(num)).Value as List<QuizViewModel>;
            return new JsonResult(sampleQuizzes.OrderBy(t => Guid.NewGuid()), new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            });
        }


        public IActionResult Put(QuizViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Post(QuizViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Delete(int id)
        {
            return Content("Not implemented (yet)");
        }

    }
}