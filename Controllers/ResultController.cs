using System;
using System.Collections.Generic;
using core2angular5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core2angular5.Controllers
{
    [Produces("application/json")]
    [Route("api/Result")]
    public class ResultController : Controller
    {
        public IActionResult All(int quizId)
        {
            var sampleQuestions = new List<ResultViewModel>
            {
                new ResultViewModel()
                {
                    Id = 1,
                    QuizId = quizId,
                    Text = "QuestionText",
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }
            };


            for (var i = 2; i < 5; i++)
            {
                sampleQuestions.Add(new ResultViewModel() { 
                    Id = 1,
                    QuizId = quizId,
                    Text = $"Text{i}",
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            return new JsonResult(sampleQuestions, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}