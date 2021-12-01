using System;

namespace Task1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String isbnNumber = null;

            //contains the method for checking validity 
            var isValid = CheckIsbn(isbnNumber);

            //print out the results of the validity.
            Console.WriteLine($"Your book {(isValid ? "has" : "doesn't have")} a valid ISBN");

            Console.ReadLine();
        }

        private static string NormalizeIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }

        private static bool CheckIsbn(string isbn)
        {
            if (isbn == null)
                return false;

            isbn = NormalizeIsbn(isbn);
            if (isbn.Length != 10)
                return false;

            int result;
            for (int i = 0; i < 9; i++)
                if (!int.TryParse(isbn[i].ToString(), out result))
                    return false;

            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (i + 1) * int.Parse(isbn[i].ToString());

            int remainder = sum % 11;
            if (remainder == 10)
                return isbn[9] == 'X';
            else
                return isbn[9] == (char)('0' + remainder);
        }
    }
}
