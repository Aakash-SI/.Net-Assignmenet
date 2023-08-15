using System;

namespace StudentMarks
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (a[i] > max) max = a[i];
            }
            int average = sum / a.Length;
            Console.WriteLine("The Average of the Given Array = " + average);
            Console.WriteLine("Maximum value =>" + max);

        }
    }
}
