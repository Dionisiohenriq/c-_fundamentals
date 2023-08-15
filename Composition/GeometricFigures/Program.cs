using GeometricFigures.Entities;
using GeometricFigures.Entities.Enums;
using System.Globalization;

Console.Write("Enter the number of shapes: ");
if (int.TryParse(Console.ReadLine(), out int n))
{

    Console.Write("Color (Black/Blue/Red): ");
    EColor color = Enum.Parse<EColor>(Console.ReadLine());

    double width, height, radius;

    List<Shape> shapes = new List<Shape>();
    for (int i = 1;  i <= n; i++)
    {
        Console.WriteLine($"Shape #{i} data: ");
        Console.Write("Rectangle or Circle (r/c)? ");
        string option = Console.ReadLine();
            
        switch (option)
        {
            case "r":
                Console.Write("Width: ");
                width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height");
                height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Rectangle(width, height, color));
                break;

            case "c":
                Console.Write("Radius: ");
                radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(color, radius));
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
    Console.WriteLine("SHAPE AREAS: ");
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));    
    }
}


