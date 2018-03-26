using System;
using System.Collections.Generic;
using core2angular5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core2angular5.Controllers
{
    [Produces("application/json")]
    [Route("api/Quiz")]
    public class QuizController : Controller
    {

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





    }
}