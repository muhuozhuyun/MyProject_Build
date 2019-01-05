using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Controllers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Web.Controllers
{
    public class MyFirstController : MyProjectControllerBase
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
