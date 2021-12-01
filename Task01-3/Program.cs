using System;
using System.Linq;

namespace Task01_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number of elements in a numeric array (at least two)");
            var n = int.Parse(Console.ReadLine());

            var array = new int[n];

            for (var i = 0; i < n; i++) array[i] = int.Parse(Console.ReadLine());

            Console.Write("Given array: ");
            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine($"Sum between {MinSearch(array)} and {MaxSearch(array)} = " +
                              $"{SumBetweenMinMax(array)}");
        }

        private static void PrintArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
        }

        private static int MaxSearch(int[] arr)
        {
            var max = arr[0];

            foreach (var i in arr)
                if (i > max)
                    max = i;

            return max;
        }

        private static int MinSearch(int[] arr)
        {
            var min = arr[0];

            foreach (var i in arr)
                if (i < min)
                    min = i;

            return min;
        }

        private static int SumBetweenMinMax(int[] arr)
        {
            var sum = 0;
            var min = arr.Min();
            var max = arr.Max();

            for (var i = min; i <= max; i++) sum = sum + arr[i];

            return sum;
        }
    }
}