using System.IO;
using System;

class Result
{
    public static string gameOfThrones(string s)
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int _length = s.Length;
        bool status = true;

        if (_length % 2 == 0)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < _length; j++)
                {
                    if (char.ToLower(alpha[i]) == char.ToLower(s[j]))
                        count++;
                }
                if (count % 2 != 0)
                    status = false;
            }
            
            if (status == false)
                return "NO";
            else
                return "YES";
        }
        else
        {
            int oddcount = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < _length; j++)
                {
                    if (char.ToLower(alpha[i]) == char.ToLower(s[j]))
                        count++;
                }
                if (count % 2 != 0)
                    oddcount++;
            }

            if (oddcount >= 2)
                return "NO";
            else
                return "YES";
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}