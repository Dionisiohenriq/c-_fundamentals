using System.Globalization;
using TaxPayers.Entities;

Console.Write("Enter the number of tax payers: ");
int taxPayers = int.Parse(Console.ReadLine());


List<Pessoa> pessoas = new List<Pessoa>();

for  (int i = 1; i <= taxPayers; i++)
{
    Console.WriteLine($"Tax #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char option = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    if (option == 'i')
    {
        Console.Write("Health Expendidures: ");
        double expendidures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        pessoas.Add(new PessoaFisica(name, income, expendidures));
    }
    else
    {
        Console.Write("Number of Employees: ");
        int qtdEmployees = int.Parse(Console.ReadLine());
        pessoas.Add(new PessoaJuridica(name, income, qtdEmployees));
    }
}

Console.WriteLine("TAXES PAID: ");
double soma = 0.0;
foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine($"{pessoa.Name} $ {pessoa.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
    soma += pessoa.TaxesPaid();
}
Console.Write($"TOTAL TAXES: {soma.ToString("F2", CultureInfo.InvariantCulture)}");