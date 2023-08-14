using Market.Entities;
using Market.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter Client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter Order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order?");
int n = int.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(status, client);



for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    int quantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem item = new OrderItem(quantity, productPrice, product);
    order.Items.Add(item);

}

Console.WriteLine(order.ToString());