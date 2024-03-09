using HashSet_SortedSet;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> hashSet = new HashSet<string>();

        hashSet.Add("TV");
        hashSet.Add("Notebook");
        hashSet.Add("Tablet");

        foreach (string hash in hashSet)
        {
            Console.WriteLine(hash);
        }


        Console.WriteLine(hashSet.Contains("Notebook"));


        SortedSet<int> sortedSetEven = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
        SortedSet<int> sortedSetOdd = new SortedSet<int>() { 1, 3, 5, 7, 9 };
        SortedSet<int> sortedSetAll = new SortedSet<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        // Union
        SortedSet<int> sortedSetU = new SortedSet<int>(sortedSetEven);
        sortedSetU.UnionWith(sortedSetOdd);
        sortedSetU.UnionWith(sortedSetAll);


        // Intersection
        SortedSet<int> sortedSetI = new SortedSet<int>(sortedSetOdd);
        sortedSetI.IntersectWith(sortedSetU);


        // Difference
        SortedSet<int> sortedSetD = new SortedSet<int>(sortedSetAll);
        sortedSetD.IntersectWith(sortedSetI);

        PrintCollection.PrintCollections(sortedSetEven);
        PrintCollection.PrintCollections(sortedSetOdd);
        Console.WriteLine("Union: ");
        PrintCollection.PrintCollections(sortedSetU);
        Console.WriteLine("Intersection: ");
        PrintCollection.PrintCollections(sortedSetI);
        Console.WriteLine("Difference: ");
        PrintCollection.PrintCollections(sortedSetD);
    }
}