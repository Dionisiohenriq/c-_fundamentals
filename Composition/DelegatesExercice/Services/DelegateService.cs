using DelegatesExercice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercice.Services
{
    public class DelegateService
    {
        public static bool MinPrice(Product p)
        {
            return p.Price > 100.0;
        }
    }
}
