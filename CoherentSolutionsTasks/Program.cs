using System;

namespace CoherentSolutionsTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number of elements in a numeric array (at least two)");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
        }


        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}]= {arr[i]}");
            }
        }
    }
}
