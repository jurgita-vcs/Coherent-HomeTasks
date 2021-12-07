using System;

namespace Task01_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 9 character-digits: ");
            string isbnNumber = Console.ReadLine();

            var isValid = IsValidIsbn(isbnNumber);

            Console.WriteLine($"Your book {(isValid ? "has" : "doesn't have")} a valid ISBN");
        }

        private static bool IsValidIsbn(string isbn)
        {
            var n = isbn.Length;
            if (n != 10)
                return false;

            var sum = 0;

            for (var i = 0; i < 9; i++)
            {
                var digit = isbn[i] - '0';

                if (digit < 0 || digit > 9)
                    return false;

                sum += digit * (10 - i);
            }

            // Checking last digit.
            var last = isbn[9];

            if (last != 'X' && (last < '0' || last > '9'))
                return false;

            sum += last == 'X' ? 10 : last - '0';

            return sum % 11 == 0;
        }
    }
}