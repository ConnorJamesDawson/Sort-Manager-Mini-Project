using SortManager.App.Model;

namespace SortManager.App.Controller;

public class HandleInput
{
    AbstractSort sortingChosen;
    public static int[] GetRandomArray(int lengthArray)
    {
        List<int> unsorted = new List<int>();
        Random random = new Random();

        Console.WriteLine("Original array elements:");
        for (int i = 0; i < lengthArray; i++)
        {
            unsorted.Add(random.Next(0, 100));
            Console.Write(unsorted[i] + " ");
        }
        int[] unsortedArray = unsorted.ToArray();
        Console.WriteLine();
        return unsortedArray;
        
    }

    public static int[] GetSortedArray(int[] array)
    {
        Console.WriteLine("Sorted array elements: ");
        
        Console.Write("\n");
        return array;
    }

}
