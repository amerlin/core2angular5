using System;
using System.Collections.Generic;
using core2angular5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core2angular5.Controllers
{
    [Produces("application/json")]
    [Route("api/Answer")]
    public class AnswerController : Controller
    {
        [HttpGet("All/{questionId}")]
        public IActionResult All(int questionId)
        {
            var sampleQuizzes = new List<AnswerViewModel>
            {
                new AnswerViewModel()
                {
                    Id = 1,
                    Text = "Title001",
                    QuestionId = questionId,
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }
            };


            for (var i = 2; i <= 5; i++)
            {
                sampleQuizzes.Add(new AnswerViewModel()
                {
                    Id = i,
                    QuestionId = questionId,
                    Text = string.Format("Quiz {0}", i),
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }


            return new JsonResult(sampleQuizzes, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }

        public IActionResult Get(int id)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Put(AnswerViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Post(AnswerViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Delete(int id)
        {
            return Content("Not implemented (yet)");
        }
    }
}