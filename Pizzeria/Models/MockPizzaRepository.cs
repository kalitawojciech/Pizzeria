using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public class MockPizzaRepository : IPizzaRepository
    {
        private List<Pizza> _pizzas;

        public MockPizzaRepository()
        {
            if(_pizzas == null)
            {
                InitializePizzas();
            }
        }

        private void InitializePizzas()
        {
            _pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Hawaiian Pizza", Price=23.99M, }
            };
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return _pizzas.FirstOrDefault(p => p.Id == pizzaId);
        }

        public IEnumerable<Pizza> GetPizzas()
        {
            return _pizzas;
        }
    }
}
