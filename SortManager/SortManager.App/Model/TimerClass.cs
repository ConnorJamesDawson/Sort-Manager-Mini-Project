namespace SortManager.App.Model;

public class TimerClass
{
    public static int GetTime(int time) => time;
    public static decimal StartTimer(decimal startTime)
    {
        startTime = DateTime.Now.Millisecond;
        return startTime;
    }

    public static decimal StopTimerAndCalculateTime(decimal startTime)
    {
        decimal timePassed = DateTime.Now.Millisecond - startTime;
        return timePassed;
    }

    public override string ToString()
    {
        return $"Time taken: {GetTime} seconds";
    }

}
