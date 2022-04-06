using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3DSurfaceArea
{
    class Result
    {

        public static int surfaceArea(List<List<int>> A)
        { 

            int h = A.Count();
            int w = A[0].Count();
            int result = 2 * h * w;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    result += (A[i][j]) * 4;


                    if (i != 0)
                    {
                        result -= 2 * Math.Min(A[i - 1][j], A[i][j]);
                    }

                    if (j != 0)
                    {
                        result -= 2 * Math.Min(A[i][j], A[i][j - 1]);
                    }
                }
            }

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int H = Convert.ToInt32(firstMultipleInput[0]);

            int W = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> A = new List<List<int>>();

            for (int i = 0; i < H; i++)
            {
                A.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList());
            }

            int result = Result.surfaceArea(A);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
