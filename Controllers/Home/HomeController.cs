using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerTest.Controllers.Home
{
    [Route("api/Manage/[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// List
        /// </summary>
        /// <returns>List</returns>
        [HttpGet]
        [Route("live")]
        public bool Live()
        {
            return true;
        }
    }
}
