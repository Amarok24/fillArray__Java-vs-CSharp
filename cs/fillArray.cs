using System;
using System.Diagnostics;
/**
 * Algorithm which fills an array (pre-defined length) with integers
 */
class FillArray
{
  static void Main(string[] args)
  {
    int[] intArray;
    int maxNum = 1000000; // by default 1 million integers in array
    Stopwatch stopwatch = new Stopwatch();

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

/*
Intel i7 2.9 GHz, Windows 10 64bit
3 test runs with parameters: 1000002, 1000003, 1000004

C# v8.0 (DotNet Core 3.1)
Time elapsed: 3ms
Time elapsed: 4ms
Time elapsed: 3ms
AVERAGE: 3.3ms

Speed with C# 9 (.NET 5) is equivalent.
*/
