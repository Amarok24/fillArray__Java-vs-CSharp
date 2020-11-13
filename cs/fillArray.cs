using System;

// Algorithm which fills an array (pre-defined length) with integers
class FillArray
{
    static void Main(string[] args)
    {
        int[] intArray;
        var maxNum = 1000000; // by default 1 million integers in array
        var stopwatch = new System.Diagnostics.Stopwatch();

        if (args.Length != 0)
        {
            Console.WriteLine("Parameter (string) provided, parsing to integer: " + args[0]);
            maxNum = Int32.Parse(args[0]);
        }
        else
        {
            Console.WriteLine("No parameter provided, using default {0}", maxNum);
        }

        intArray = new int[maxNum];
        stopwatch.Start();

        for (int i = 0; i < maxNum; i++)
        {
            intArray[i] = i;
        }

        stopwatch.Stop();
        Console.WriteLine("Time elapsed: {0}{1}", stopwatch.ElapsedMilliseconds, "ms");
    }
}
