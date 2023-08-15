using System;

namespace ArrayOperations
{
    class Day_1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
