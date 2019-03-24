using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PizzaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Pizza GetPizzaById(int pizzaId)
        {
            return _appDbContext.Pizzas.FirstOrDefault(pizza => pizza.Id == pizzaId);
        }

        public IEnumerable<Pizza> GetPizzas()
        {
            return _appDbContext.Pizzas;
        }
    }
}
