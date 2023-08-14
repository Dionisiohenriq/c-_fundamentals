using Produtos.Entities;
using System.Globalization;




Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    string option = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    if (double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double price))
    {

        switch (option)
        {
            case "u":
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                products.Add(new UsedProduct(date, name, price));
                break;

            case "i":
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(customsFee, name, price));
                break;

            default:
                products.Add(new Product(name, price));
                break;
        }
    }
}

Console.WriteLine("PRICE TAGS: ");

foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}








