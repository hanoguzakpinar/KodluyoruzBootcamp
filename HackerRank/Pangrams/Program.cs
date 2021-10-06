using System.IO;
using System;

class Result
{
    public static string pangrams(string s)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        char[] value = s.ToCharArray();

        int pangram = 0;

        for (int i = 0; i < alpha.Length; i++)
        {
            for (int j = 0; j < value.Length; j++)
            {
                if (char.ToLower(alpha[i]) == char.ToLower(value[j]))
                {
                    pangram++;
                    break;
                }
            }
        }

        if (pangram == 26)
            return "pangram";
        else
            return "not pangram";
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
