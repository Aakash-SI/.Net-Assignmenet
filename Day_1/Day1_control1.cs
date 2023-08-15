using System;

namespace CreditChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
