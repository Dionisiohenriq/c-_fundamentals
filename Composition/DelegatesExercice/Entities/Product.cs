using System.Globalization;

namespace DelegatesExercice.Entities
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
