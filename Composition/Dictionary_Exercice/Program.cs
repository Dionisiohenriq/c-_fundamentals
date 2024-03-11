internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> data = new Dictionary<string, int>();

        Console.WriteLine("Enter full file path: ");
        string path = Console.ReadLine();

        using(StreamReader sr = new StreamReader(path))
        {
            while(!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');

                string cadidateName = line[0];
                int votes = int.Parse(line[1]);

                if(data.ContainsKey(cadidateName))
                {
                    data[cadidateName] += votes;
                }
                else
                {
                    data.Add(cadidateName, votes);
                }
            }
        }

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}