using System;

namespace StringFun
{
    class Prg
    {

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int pos = 2;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a[pos - 1])
                {
                    a[i] = a[i + 1];
                    i++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[i + 1])
                {
                    Console.WriteLine(a[i]);
                    if (i + 1 == a.Length - 1)
                    {
                        Console.WriteLine(a[i + 1]);
                        break;
                    }
                }
            }

        }
    }
}
