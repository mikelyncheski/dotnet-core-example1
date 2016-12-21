using System;
using Microsoft.AspNetCore.Mvc;

namespace Example1.Controllers
{
    // http://localhost:5000/api/helloworld
    public class HelloWorldController : Controller
    {
        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World",
                time = DateTime.Now,
                eat = "food",
                pray = "for food",
                love = "your food"
            };
        }
    }

}