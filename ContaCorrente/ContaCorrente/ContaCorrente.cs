using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class Conta
    {
        private int Account { get; set; }
        private string Client { get; set; }
        private decimal Balance { get; set; } = 0;

        public decimal Taxa = 5.00M;
        
        public Conta()
        {

        }
        
        public Conta(int account, string client, decimal initialFee, decimal balance)
        {
            Account = account;
            Client = client;
            Balance = balance;
        }
        
        public void Depositar(string valor)
        {
            if(decimal.TryParse(valor, out decimal val))
            {
                Balance += val;
            }
            else
            {
                Console.WriteLine("Valor inválido para o saque");
            }
        }


        public void setInitialFee(string valor)
        {
            if (decimal.TryParse(valor, out var val))
            {
                Balance += val;
            }
        }


        public void Sacar(string valor)
        {
            if(decimal.TryParse(valor, out var val) && Balance >= 0)
            {
                if(Balance - val >= 0)
                    Balance -= (val + Taxa);
                
            }
            else
            {
                Console.WriteLine("Valor inválido para o saque");
            }

        }

        public override string ToString()
        {
            return $"Titular: {Client}\n" +
                    $"Conta: {Account:F2}\n" +
                    $"Saldo: {Balance:F2}\n";
        }

    }
}
