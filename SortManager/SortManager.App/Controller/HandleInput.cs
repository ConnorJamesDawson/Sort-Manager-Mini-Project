using SortManager.App.Model;

namespace SortManager.App.Controller;

public class HandleInput
{
    AbstractSort sortingChosen;
    public void StartUpArrayMessage()
    {
        List<int> unsorted = new List<int>();
        List<int> sorted;

        Random random = new Random();

        Console.WriteLine("Original array elements:");
        for (int i = 0; i < 10; i++)
        {
            unsorted.Add(random.Next(0, 100));
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();

        // TO DO - implement sorting chosen

        Console.WriteLine("Sorted array elements: ");
/*        foreach (int x in sorted)
        {
            Console.Write(x + " ");
        }*/
        Console.Write("\n");
    }

}
