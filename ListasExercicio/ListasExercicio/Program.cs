// See https://aka.ms/new-console-template for more information


using ListasExercicio;
using System.Globalization;

Employee employee = new Employee();

employee.ColectInformations();

Console.Write("Enter the employee Id that will have salary increase: ");
if(int.TryParse(Console.ReadLine(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int id))
{
    Console.Write("Enter the percentage: ");
    if(double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double percentage))
    {
        employee.IncreaseSalary(id, percentage);
        employee.Print();
    }
}



