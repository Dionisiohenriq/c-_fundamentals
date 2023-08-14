
using System.Globalization;

namespace ListasExercicio
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public List<Employee> Employees = new List<Employee>();


        public Employee() { }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void ColectInformations()
        {
            Console.WriteLine("How many employees will be registered?");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine($"Employee #{i}");
                    Console.Write("Id: ");
                    if(int.TryParse(Console.ReadLine(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int id))
                    {

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Salary: ");
                        if(double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double salary)){


                            Employees.Add(new Employee()
                            {
                                Id = id,
                                Name = name,
                                Salary = salary
                            });

                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id. Must be an integer number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void IncreaseSalary(int id, double percentage)
        {

            Employee employeeSelected = Employees.FirstOrDefault(_ => _.Id.Equals(id)) ?? new Employee();

            employeeSelected.Salary += employeeSelected.Salary * (percentage / 100);

        }


        public void Print()
        {
            Console.WriteLine("Updated list of Employees: ");
            Employees.ForEach(e => Console.WriteLine($"{e.Id}, {e.Name}, {e.Salary.ToString("F2", CultureInfo.InvariantCulture)}"));
        }
    }
}
