using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppendAndDelete
{
    class Result
    {

        /*
         * Complete the 'appendAndDelete' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. STRING t
         *  3. INTEGER k
         */

        public static string appendAndDelete(string s, string t, int k)
        {
            string result = "";

            int n = s.Length;
            int m = t.Length;
            int difference = n - m;
            int sum = n + m;

            if (k < difference)
            {
                result = "No";
            }
            else if (sum >= k)
            {
                result = "Yes";
            }
            else if (sum - k <= 0)
            {
                result = "Yes";
            }
            else if (Math.Abs((sum - k) % 2) == 0)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.appendAndDelete(s, t, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
