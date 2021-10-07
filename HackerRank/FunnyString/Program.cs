using System.IO;
using System.Linq;
using System;

class Result
{
    public static string funnyString(string s)
    {
        int length = s.Length;
        char[] chars = s.ToCharArray();
        int[] asciss= new int[length];
        int[] diff = new int[length];
        int[] diffx = new int[length];
        
        for(int i=0;i<length;i++)
            asciss[i] = Convert.ToInt32(chars[i]);
        
        for(int i=0;i<length-1;i++)
            diff[i] = Math.Abs(asciss[i]-asciss[i+1]);
        
        Array.Reverse(asciss);
        
        for(int i=0;i<length-1;i++)
            diffx[i] = Math.Abs(asciss[i]-asciss[i+1]);
        
        if(diff.SequenceEqual(diffx))
            return "Funny";
        else
            return "Not Funny";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}