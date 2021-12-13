using System;

namespace Task01_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer numbers");
            try
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                Console.WriteLine("Numbers that have exactly two 2's: ");

                Console.WriteLine(a <= b ? PrintTwoOfTwos(a, b) : PrintTwoOfTwos(b, a));
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, input integer numbers");
            }
        }

        private static int CountOccurrenceOfTwo(int number)
        {
            var count = 0;

            while (number > 0)
            {
                var remainder = number % 10;
                if (remainder == 2)
                    count++;
                number /= 10;
            }

            return count;
        }

        private static int ConvertNumberToTernary(int number)
        {
            var result = string.Empty;
            while (number > 0)
            {
                result = number % 3 + result;
                number /= 3;
            }

            return Convert.ToInt32(result);
        }

        private static int PrintTwoOfTwos(int a, int b)
        {
            for (var i = a; i <= b; i++)
            {
                if (CountOccurrenceOfTwo(ConvertNumberToTernary(i)) == 2)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
