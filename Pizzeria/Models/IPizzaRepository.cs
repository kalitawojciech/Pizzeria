﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> GetPizzas();
        Pizza GetPizzaById(int pizzaId);
    }
}
