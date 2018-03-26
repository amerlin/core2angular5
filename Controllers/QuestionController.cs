using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core2angular5.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core2angular5.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        public IActionResult All(int quizId)
        {
            var sampleQuestions = new List<QuestionViewModel>
            {
                new QuestionViewModel()
                {
                    Id = 1,
                    QuizId = quizId,
                    Text = "QuestionText",
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }
            };


            for (var i = 2; i < 5; i++)
            {
                sampleQuestions.Add(new QuestionViewModel()
                {
                    Id = 1,
                    QuizId = quizId,
                    Text = $"Text{i}",
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            return new JsonResult(sampleQuestions, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }


        public IActionResult Get(int id)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Put(QuestionViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Post(QuestionViewModel model)
        {
            return Content("Not implemented (yet)");
        }

        public IActionResult Delete(int id)
        {
            return Content("Not implemented (yet)");
        }

    }
}