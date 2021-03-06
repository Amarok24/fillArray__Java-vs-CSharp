using System;
using System.Collections.Generic;
using System.Diagnostics;

/**
 * Algorithm which pushes integers to a dynamic (growing) array, here using generic List<T>
 */
class GrowList
{
  static void Main(string[] args)
  {
    List<int> intArray = new List<int>();
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

    stopwatch.Start();

    for (int i = 0; i < maxNum; i++)
    {
      intArray.Add(i);
    }

    stopwatch.Stop();
    Console.WriteLine("Time elapsed: {0}{1}", stopwatch.ElapsedMilliseconds, "ms");
  }
}

/*
Intel i7 2.9 GHz, Windows 10 64bit
3 test runs with parameters: 1000002, 1000003, 1000004

C# v8.0 (DotNet Core)
Time elapsed: 6ms
Time elapsed: 7ms
Time elapsed: 6ms
AVERAGE: 6.3ms

Speed with C# 9 (.NET 5) is equivalent.
*/
