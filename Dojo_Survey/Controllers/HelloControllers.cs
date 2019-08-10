    using Microsoft.AspNetCore.Mvc;
    using System;
    using Dojo_Survey.Models;

    namespace Dojo_Survey     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            
            [Route("")]     
            [HttpGet]
            public IActionResult Index()
            {  
                ViewBag.Example = "survey";
                return View();
            }   

                   
            // [Route("method")]     
            // [HttpPost]
            // public IActionResult Method(string name, string location, string language, string comment)
            // {
            
            //     ViewBag.Name = name;
            //     ViewBag.Location = location;
            //     ViewBag.Language =language;
            //     ViewBag.Comment = comment; 

            //     return View("result");
                   
            // }

            [HttpPost("method")]
            public IActionResult Submission (Survey yourSurvey)
            {

                return View(yourSurvey);
            }
        
           
        }
    }