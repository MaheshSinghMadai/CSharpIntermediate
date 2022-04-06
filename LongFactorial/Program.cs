using System;
using System.Numerics;

namespace LongFactorial
{
    class Result
    {

        /*
         * Complete the 'extraLongFactorials' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void extraLongFactorials(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.extraLongFactorials(n);
        }
    }

}
