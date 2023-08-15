// See https://aka.ms/new-console-template for more information



using Bank.Entities;
using Bank.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial Balance: ");
    double initalBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();

    Console.Write("Enter ammount for withdraw: ");
    double ammount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, initalBalance, withdrawLimit);
    account.Withdraw(ammount);

    Console.WriteLine(account.ToString());

}
catch (DomainException e)
{
    Console.Write("Error: " + e.Message);
}
catch (FormatException e)
{
    Console.Write("Incorrect format: " + e.Message);
}
catch (Exception e)
{
    Console.Write("Exception: " + e.Message);
}


