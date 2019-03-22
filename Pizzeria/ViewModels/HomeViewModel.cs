using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
