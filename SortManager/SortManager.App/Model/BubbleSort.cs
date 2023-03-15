
namespace SortManager.App.Model;

public class BubbleSort : AbstractSort
{
    public override int[] SortArray(int[] array)
    {
        GetUnsortedArray = array;
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        GetArray= array;
        return array;
    }
}