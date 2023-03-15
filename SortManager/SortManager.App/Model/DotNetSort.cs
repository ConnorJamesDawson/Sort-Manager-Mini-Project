using System.Diagnostics;

namespace SortManager.App.Model;

public class DotNetSort : AbstractSort
{
    public override int[] SortArray(int[] array)
    {
        Stopwatch timer = TimerClass.StartTimer();

        Array.Sort(array);

        TimerClass.StopTimerAndReturnTime(timer);
        return array;
    }
}