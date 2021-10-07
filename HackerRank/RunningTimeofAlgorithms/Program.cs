using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int runningTime(List<int> A)
    {
        int shift = 0;
        for (int i = 0; i < A.Count - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (A[j - 1] > A[j])
                {
                    int temp = A[j - 1];
                    A[j - 1] = A[j];
                    A[j] = temp;
                    shift++;
                }
            }
        }
        return shift;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.runningTime(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}