using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int N = arr.Count;
        int T=0,T2=0,T3=0;
        
        for(int i=0;i<N;i++)
        {
            for(int j=0;j<N;j++)
            {
                if(i==j)
                    T += arr[i][j];
                
                if((i+j) == (N -1))
                    T2 += arr[i][j];
            }
        }
        
        T3=T-T2;
        
        return Math.Abs(T3);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
