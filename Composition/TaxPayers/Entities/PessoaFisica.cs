using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayers.Entities
{
    public class PessoaFisica : Pessoa
    {
        public double HealthExpendidures { get; set; }
        public PessoaFisica()
        {
            
        }

        public PessoaFisica(string name, double anualIncome, double healthExpendidures) : base(name, anualIncome)
        {
            HealthExpendidures = healthExpendidures;
        }

        public override double TaxesPaid()
        {
            double taxPaid;
            if (AnualIncome < 20000.00)
            {
                taxPaid = AnualIncome * 0.15;
            }
            else
            {
                taxPaid = AnualIncome * 0.25 ;
            }
            if(HealthExpendidures > 0)
            {
                taxPaid -= HealthExpendidures * 0.5;
            }
            return taxPaid;
        }
    }
}
