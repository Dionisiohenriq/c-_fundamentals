using IComparableTest.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = [new Product("TV", 900.00), 
                                new Product("Notebook", 1200.00), 
                                new Product("Tablet", 450.00)];
        // Com lambda
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }

        // Implementação de sobrecarga para o método Sort() (Delegate)
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}