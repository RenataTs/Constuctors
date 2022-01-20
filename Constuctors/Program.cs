using ListsLibrary;
using System;

namespace Constuctors
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> array = new ArrayList<int>(5);

            Console.WriteLine(array.IndexByItem(10));

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
