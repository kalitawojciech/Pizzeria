using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;
using Pizzeria.ViewModels;

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
            var pizzas = _pizzaRepository.GetPizzas().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome in our Pizzeria!",
                Pizzas = pizzas.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pizza = _pizzaRepository.GetPizzaById(id);
            if(pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }
    }
}
