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

                Console.WriteLine("Ternary numbers sequence: ");
                if (a <= b)
                {
                    PrintConvertedTernaryNumbers(a, b);
                    Console.WriteLine("Numbers that have exactly two 2's: ");
                    PrintTwoOfTwos(a, b);
                }
                else
                {
                    PrintConvertedTernaryNumbers(b, a);
                    Console.WriteLine("Numbers that have exactly two 2's: ");
                    PrintTwoOfTwos(b, a);
                }
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

        private static int CountTwoOfTwos(int number)
        {
            return CountOccurrenceOfTwo(number) == 2 ? number : 0;
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

        private static void PrintConvertedTernaryNumbers(int a, int b)
        {
            for (var i = a; i <= b; i++) 
                Console.WriteLine(ConvertNumberToTernary(i));
        }

        private static void PrintTwoOfTwos(int a, int b)
        {
            for (var i = a; i <= b; i++)
            {
                var number1 = ConvertNumberToTernary(i);
                var number2 = CountTwoOfTwos(ConvertNumberToTernary(i));
                if (number1 == number2) 
                    Console.WriteLine(number1 + " ");
            }
        }
    }
}
