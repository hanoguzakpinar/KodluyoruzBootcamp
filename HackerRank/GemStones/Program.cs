using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int gemstones(List<string> arr)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int length = arr.Count;
        int[] sayac = new int[alpha.Length];

        for (int i = 0; i < length; i++)
        {
            var word = new string(arr[i].ToCharArray().Distinct().ToArray());

            for (int j = 0; j < word.Length; j++)
            {
                for (int x = 0; x < alpha.Length; x++)
                {
                    if (char.ToLower(word[j]) == char.ToLower(alpha[x]))
                        sayac[x]++;
                }
            }
        }

        int lcount = 0;

        for (int i = 0; i < sayac.Length; i++)
        {
            if (sayac[i] == length)
                lcount++;
        }

        return lcount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}