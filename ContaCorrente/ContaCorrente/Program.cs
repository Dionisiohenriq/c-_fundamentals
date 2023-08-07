


using ContaCorrente;

internal class Program
{
    private static void Main(string[] args)
    {
        var programa = new Conta();
        programa.setInitialFee("100.00");
        Console.WriteLine(programa.ToString());
        programa.Depositar("200");
        programa.Sacar("300");
        Console.WriteLine(programa.ToString());
    }
}