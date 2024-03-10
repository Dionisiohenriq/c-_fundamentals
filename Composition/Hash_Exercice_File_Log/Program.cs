using Hash_Exercice_File_Log.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<LogRecord> set = new HashSet<LogRecord>();

        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        try
        {
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    set.Add(new LogRecord(line[0], DateTime.Parse(line[1])));
                }

                Console.WriteLine($"Total users: {set.Count}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}