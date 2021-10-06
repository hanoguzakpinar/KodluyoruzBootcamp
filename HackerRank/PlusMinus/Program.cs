using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        int pos=0,neg=0,zer0=0;
        int N = arr.Count;
        
        for(int i=0;i<N;i++)
        {
            if(arr[i]>0)
            {
                pos++;
            }
            if(arr[i]<0)
            {
                neg++;
            }
            if(arr[i]==0)
            {
                zer0++;
            }  
        }
        
        Console.WriteLine((float)pos/N);
        Console.WriteLine((float)neg/N);
        Console.WriteLine((float)zer0/N);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}