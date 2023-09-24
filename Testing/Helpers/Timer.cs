using System.Diagnostics;

namespace Helpers;

public class TimeHelper
{
    public Stopwatch StartTimer()
    {
        var timer = new Stopwatch();
        timer.Start();
        return timer;
    }

    public void StopAndLog(Stopwatch timer, string source, string result)
    {
        timer.Stop();
        Log(timer, source, result);
    }

    private void Log(Stopwatch timer, string source, string result)
    {
        Console.WriteLine($"Time Elapsed: {timer.ElapsedTicks}, Source: {source}, Results: {result}");
    }

    public List<int> Run(Func<List<int>> func, string source)
    {
        var timer = StartTimer();
        var result = func();
        var resultText = string.Join(", ", result.ToArray());
        StopAndLog(timer, source, resultText);
        return result;
    }
}
