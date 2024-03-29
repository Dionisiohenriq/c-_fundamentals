using FuncExample.Entities;

namespace FuncExample;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("TV", 900.00));
        products.Add(new Product("Mouse", 50.00));
        products.Add(new Product("Tablet", 350.50));
        products.Add(new Product("HD Case", 80.90));

        Func<Product, string> func = p => p.Name.ToUpper();



        List<string> result = products.Select(func).ToList();
        List<string> result2 = products.Select(p => p.Name.ToUpper()).ToList();


        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        
    }

    static string NameUpper(Product product)
    {
        return product.Name.ToUpper();
    }

}