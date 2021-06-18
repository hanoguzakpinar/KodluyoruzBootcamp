using System;

namespace stringlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "CSharp Exercises";
            string txxt = "CSharp ";

            System.Console.WriteLine("Uzunluk: "+txt.Length);
            System.Console.WriteLine("Upper: "+txt.ToUpper());
            System.Console.WriteLine("Lower: "+txt.ToLower());

            System.Console.WriteLine(String.Concat(txt,"with me"));

            System.Console.WriteLine(txt.CompareTo(txxt)); // uzunluk karşılaştırma 0 eşit 1 txt büyük -1 txxt büyük
            System.Console.WriteLine(String.Compare(txt,txxt,true)); // true olursa büyükküçük harf duyarlı
            System.Console.WriteLine(String.Compare(txt,txxt,false)); // false olursa büyükküçük harf duyarsız

            System.Console.WriteLine(txt.Contains(txxt));

            System.Console.WriteLine(txt.EndsWith("ses"));
            System.Console.WriteLine(txt.StartsWith("CS"));

            System.Console.WriteLine(txt.IndexOf("CS"));
            System.Console.WriteLine(txt.LastIndexOf("s"));

            System.Console.WriteLine(txt.Insert(16," 2021"));

            System.Console.WriteLine(txt.Remove(10));
            System.Console.WriteLine(txt.Remove(10,2));

            System.Console.WriteLine(txt.Split(' ')[1]); // bölüp diziye atar.

            System.Console.WriteLine(txt.Replace("CSharp","C#"));
            System.Console.WriteLine(txt.Replace(" ",""));

            System.Console.WriteLine(txt.Substring(8));
            System.Console.WriteLine(txt.Substring(0,6));

            System.Console.WriteLine(txt + txxt.PadLeft(10));
            System.Console.WriteLine(txt + txxt.PadLeft(10,'*'));
            System.Console.WriteLine(txt.PadRight(50) + txxt);
            System.Console.WriteLine(txt.PadRight(50,'/') + txxt);
            
        }
    }
}
