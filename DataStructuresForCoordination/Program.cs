using System;
using System.Collections.Concurrent;

namespace DataStructuresForCoordination
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMITEMS = 64;
            int initialCapacity = 101;

            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;

            // Construct the dictionary with the desired concurrencyLevel and initialCapacity
            ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>(concurrencyLevel, initialCapacity);

            // Initialize the dictionary
            for (int i = 0; i < NUMITEMS; i++) cd[i] = i * i;

            Console.WriteLine("The square of 23 is {0} (should be {1})", cd[23], 23 * 23);
        }
    }
}
