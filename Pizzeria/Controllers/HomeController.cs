using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;
        public HomeController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository; ;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
