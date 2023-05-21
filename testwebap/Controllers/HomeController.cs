namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using AutoMapper; 

    public class HomeController : Controller
    {   
       public IActionResult Indexeng() =>  View();
        public IActionResult Index() => View();
        public IActionResult Goals() =>  View();
        public IActionResult Account() =>  View();        
        public IActionResult Logup() =>  View();
        public IActionResult Stats() =>  View();
        public IActionResult Statseng() =>  View();
        
        public IActionResult New() =>  View();
        public IActionResult Statistic() =>  View();

        [HttpGet]
        public IActionResult Login() => View();
        
    }
