using DelegatesTest.Services;

namespace DelegatesTest
{
    // declaration
    delegate void BinaryNumericOperation(double n1, double n2);
    public class Program
    {
        private static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            

            // Usage
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.ShowSum);
            op += CalculationService.ShowMax;

            op(a, b);

        }
    }
}
