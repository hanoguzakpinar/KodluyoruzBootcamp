using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int makingAnagrams(string s1, string s2)
    {
        int equal = 0;
        List<char> s1L = new List<char>(s1.Length);
        List<char> s2L = new List<char>(s2.Length);
        s1L = s1.ToList(); s2L = s2.ToList();

        for (int i = 0; i < s1.Length; i++)
        {
            if (s2L.Contains(s1L[i]))
            {
                equal++;
                s2L.Remove(s1L[i]);
            }
        }

        return (s1.Length - equal) + (s2.Length - equal);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = Result.makingAnagrams(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}