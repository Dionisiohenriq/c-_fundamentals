using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayers.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;

        }
        public PessoaJuridica()
        {

        }
        public override double TaxesPaid()
        {
            if (NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
