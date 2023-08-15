using Bank.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            if(ammount > Balance)
            {
                throw new DomainException("Insuficient Balance!");
            }
            if(ammount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit exceded!");
            }
            
            Balance -= ammount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
