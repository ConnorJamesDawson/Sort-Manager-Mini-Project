using SortManager.App.Model;
namespace TimerClassTest;

public class TimerTests
{

    [Test]
    public void StartTimer_ReturnsCurrentTimeinSecond()
    {
        int startTime = TimerClass.StartTimer(DateTime.Now.Second);
        Assert.That(startTime,Is.EqualTo(DateTime.Now.Second));
    }

    [TestCase(60)]
    [TestCase(50)]
    [TestCase(30)]
    public void StopTimerAndCalculateTime_ReturnsCurrentTimeinSecond(int time)
    {
        int timePassed = TimerClass.StopTimerAndCalculateTime(time);
        Assert.That(timePassed, Is.EqualTo(DateTime.Now.Second - time));
    }

    [Test]
    public void ToString_ReturnTimeTaken()
    {
        string timeTaken = $"Time Taken: {TimerClass.GetTime(60)} seconds";
        Assert.That(timeTaken, Is.EqualTo("Time Taken: 60 seconds"));
    }
}