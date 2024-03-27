using System.Diagnostics;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        LoopString();
        DateTime end = DateTime.Now;
        Console.WriteLine($"DateTime LoopString:          {end - start}");

        start = DateTime.Now;
        LoopStringBuilder();
        end = DateTime.Now;
        Console.WriteLine($"DateTime LoopStringBuilder:   {end - start}");

        Console.WriteLine("==============================================");

        Stopwatch sw = new Stopwatch();
        sw.Start();
        LoopString();
        sw.Stop();
        Console.WriteLine($"Stopwatch LoopString:         {sw.Elapsed}");

        sw.Restart();
        LoopStringBuilder();
        sw.Stop();
        Console.WriteLine($"Stopwatch LoopStringBuilder:  {sw.Elapsed}");

    }

    public static void LoopString()
    {
        var str = "Hello World!";
        for (int i = 0; i < 1000; i++)
        {
            str += i;
        }
    }

    public static void LoopStringBuilder()
    {
        var sb = new StringBuilder();
        sb.Append("Hello World!");
        for (int i = 0; i < 1000; i++)
        {
            sb.Append(i);
        }
    }

}