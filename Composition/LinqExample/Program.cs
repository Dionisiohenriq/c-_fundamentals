internal class Program
{
    private static void Main(string[] args)
    {
        // Specify the data source
        int[] numbers = { 1, 2, 3, 4, 5, 6};

        // Define the query expression
        IEnumerable<int> result = numbers
            .Where(number => number % 2 == 0)
            .Select( number => number * 10);

        // Execute the query
        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}