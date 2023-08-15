using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayers.Entities
{
    public abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public Pessoa()
        {

        }
        protected Pessoa(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
