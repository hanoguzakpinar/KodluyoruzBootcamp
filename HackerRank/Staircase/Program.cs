using System;

class Result
{
    public static void staircase(int n)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.Write("\n");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}