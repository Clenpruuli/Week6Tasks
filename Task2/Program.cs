using System;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            int sum = 0;

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 11);
            }
          
            foreach (int num in array)
            {
                sum = sum + num;
            }
            Console.WriteLine("Sum of array elements is:" + sum);



        }
    }
}
