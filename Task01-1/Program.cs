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
                PrintTernaryNumber(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, input integer numbers");
            }
        }
        private static bool IsNumberTernary(int number)
        {
            while (number > 0)
            {
                var num = number % 10;

                if ((num != 0) && (num != 1) && (num != 2))
                {
                    return (false);
                }
                number = number / 10;

                if (number == 0)
                {
                    return (true);
                }
            }
            return false;
        }
        private static void PrintTernaryNumber(int a, int b)
        {
            if (a < b)
            {
                for (var i = a; i <= b; i++)
                {
                    if (IsNumberTernary(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (var i = a; i >= b; i--)
                {
                    if (IsNumberTernary(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
