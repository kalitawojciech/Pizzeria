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
                new Pizza { Id = 1, Name = "Pizza 1", Price = 23.99M, IsPizzaOfTheWeek = true, ShortDescription = "Pizza number 1", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas eget auctor purus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur ut felis eu augue varius posuere. Sed vitae arcu quis neque aliquet dictum vitae vitae urna. Praesent est augue, finibus efficitur consequat in, scelerisque nec felis. Mauris vel dolor tincidunt orci ultricies feugiat. Aenean massa eros, vehicula sit amet condimentum a, lacinia eu erat. Vestibulum eget mi at lorem pulvinar efficitur vel non dolor. Aliquam ac orci semper, congue justo et, consequat enim. Ut pulvinar justo et purus fringilla facilisis eu vitae enim. Donec accumsan libero arcu, et iaculis sem pharetra at. Cras consectetur quam eget est consequat, sed convallis nunc pulvinar.", ImageUrl = @"/images/pizza1.jpg"},
                new Pizza { Id = 2, Name = "Pizza 2", Price = 29.99M, IsPizzaOfTheWeek = false, ShortDescription = "Pizza number 2", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas eget auctor purus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur ut felis eu augue varius posuere. Sed vitae arcu quis neque aliquet dictum vitae vitae urna. Praesent est augue, finibus efficitur consequat in, scelerisque nec felis. Mauris vel dolor tincidunt orci ultricies feugiat. Aenean massa eros, vehicula sit amet condimentum a, lacinia eu erat. Vestibulum eget mi at lorem pulvinar efficitur vel non dolor. Aliquam ac orci semper, congue justo et, consequat enim. Ut pulvinar justo et purus fringilla facilisis eu vitae enim. Donec accumsan libero arcu, et iaculis sem pharetra at. Cras consectetur quam eget est consequat, sed convallis nunc pulvinar.", ImageUrl = @"/images/pizza2.jpg"},
                new Pizza { Id = 3, Name = "Pizza 3", Price = 20.99M, IsPizzaOfTheWeek = false, ShortDescription = "Pizza number 3", LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas eget auctor purus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur ut felis eu augue varius posuere. Sed vitae arcu quis neque aliquet dictum vitae vitae urna. Praesent est augue, finibus efficitur consequat in, scelerisque nec felis. Mauris vel dolor tincidunt orci ultricies feugiat. Aenean massa eros, vehicula sit amet condimentum a, lacinia eu erat. Vestibulum eget mi at lorem pulvinar efficitur vel non dolor. Aliquam ac orci semper, congue justo et, consequat enim. Ut pulvinar justo et purus fringilla facilisis eu vitae enim. Donec accumsan libero arcu, et iaculis sem pharetra at. Cras consectetur quam eget est consequat, sed convallis nunc pulvinar.", ImageUrl = @"/images/pizza3.jpg"}
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
