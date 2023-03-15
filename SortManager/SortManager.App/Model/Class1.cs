namespace SortManager.App.Model;

public class DotNetSort : AbstractSort
{
    public override int[] SortArray(int[] array)
    {
        Array.Sort(array);

        return array;
    }
}