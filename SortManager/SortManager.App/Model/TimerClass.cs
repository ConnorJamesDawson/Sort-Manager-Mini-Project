namespace SortManager.App.Model;

public class TimerClass
{
    public static int GetTime(int time) => time;
    public static int StartTimer(int startTime)
    {
        startTime = DateTime.Now.Second;
        return startTime;
    }

    public static int StopTimerAndCalculateTime(int startTime)
    {
        int timePassed = DateTime.Now.Second - startTime;
        return timePassed;
    }

    public override string ToString()
    {
        return $"Time taken: {GetTime} seconds";
    }

}
