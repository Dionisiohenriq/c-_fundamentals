
internal class Program
{
    private static void Main(string[] args)
    {

        DateTime dt = new DateTime(2024, 01, 11, 8, 10, 45);


        Console.WriteLine(dt.ElapsedTime());


        string s1 = "Good morning dear students!";

        Console.WriteLine(s1.Cut(10));

    }
}