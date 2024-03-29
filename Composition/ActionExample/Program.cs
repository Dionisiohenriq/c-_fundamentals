using ActionExample.Entities;


namespace ActionExample
{
    public class Program
    {
        delegate void BinaryNumericOperation(List<Product> products);
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            static void UpdatePrice(Product product)
            {
                product.Price += product.Price * 0.1;
            }

            Action<Product> act = p => { p.Price += p.Price * 0.1;  };

            products.ForEach(act);
            products.ForEach(p => { p.Price += p.Price * 0.1; });
            products.ForEach(UpdatePrice);


            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}