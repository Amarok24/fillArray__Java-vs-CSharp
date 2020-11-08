using System;
using System.Collections;
using System.Diagnostics;

/**
 * Algorithm which pushes integers to a dynamic (growing) array, here using heterogenous ArrayList
 */
class GrowHetArrayList
{
  static void Main(string[] args)
  {
    ArrayList hetArray = new ArrayList(); // ArrayList can hold mixed types, therefore slow
    int maxNum = 1000000; // by default 1 million integers in array
    Stopwatch stopwatch = new Stopwatch();

    if (args.Length != 0)
    {
      Console.WriteLine("AL Parameter (string) provided, parsing to integer: " + args[0]);
      maxNum = Int32.Parse(args[0]);
    }
    else
    {
      Console.WriteLine("AL No parameter provided, using default {0}", maxNum);
    }

    stopwatch.Start();

    for (int i = 0; i < maxNum; i++)
    {
      hetArray.Add(i);
    }

    stopwatch.Stop();
    Console.WriteLine("Time elapsed: {0}{1}", stopwatch.ElapsedMilliseconds, "ms");
  }
}

/*
Intel i7 2.9 GHz, Windows 10 64bit, C# v8.0 (DotNet Core)

3 test runs with parameters: 1000002, 1000003, 1000004

Time elapsed: 95ms
Time elapsed: 70ms
Time elapsed: 74ms
AVERAGE: 79.7ms
*/
