using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedaack(Feedback feedback);
    }
}
