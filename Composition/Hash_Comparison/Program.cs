using Hash_Comparison.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("Maria");
        set.Add("Alex");

        // Primeiro executa GetHashCode e depois Equals para confirmar
        Console.WriteLine(set.Contains("Maria"));

        HashSet<Product> productA = [new Product("TV", 1.100), new Product("Notebook", 1.200)];
        HashSet<Point> pointA = [new Point(3, 4), new Point(5, 10)];

        Product prod = new Product("Notebook", 1.200);
        Point point = new Point(5, 10);

        Console.WriteLine(productA.Contains(prod));
        Console.WriteLine(pointA.Contains(point));

    }
}