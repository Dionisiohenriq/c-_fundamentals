using Generics2.Entities;
using Generics2.Services;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {

                for (int i = 0; i < n; i++)
                {
                    string[] vect = Console.ReadLine().Split(',');

                    string name = vect[0];
                    if (double.TryParse(vect[1], out double price))
                    {
                        list.Add(new Product(name, price));
                    }
                }                

                CalculationService calculationService = new CalculationService();

                Product max = calculationService.Max(list);

                Console.WriteLine($"Max: \n{max}");
            }
        }
    }
}