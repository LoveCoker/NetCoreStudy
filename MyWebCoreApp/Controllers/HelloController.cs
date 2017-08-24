using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebCoreApp.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name,int num)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = num;
            return View();
        }

        // GET: /Hello/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /Hello/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        public string WelcomeWithParame(int id,string name)
        {
            return string.Format("编号：{0}，Welcome to Bejing, {1}.", id, name);
        }
    }
}
