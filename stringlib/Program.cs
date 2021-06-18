using System;

namespace stringlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "CSharp Exercises";
            string txxt = "CSharp ";

            Console.WriteLine("Uzunluk: "+txt.Length);
            Console.WriteLine("Upper: "+txt.ToUpper());
            Console.WriteLine("Lower: "+txt.ToLower());

            Console.WriteLine(String.Concat(txt,"with me"));

            Console.WriteLine(txt.CompareTo(txxt)); // uzunluk karşılaştırma 0 eşit 1 txt büyük -1 txxt büyük
            Console.WriteLine(String.Compare(txt,txxt,true)); // true olursa büyükküçük harf duyarlı
            Console.WriteLine(String.Compare(txt,txxt,false)); // false olursa büyükküçük harf duyarsız

            Console.WriteLine(txt.Contains(txxt));

            Console.WriteLine(txt.EndsWith("ses"));
            Console.WriteLine(txt.StartsWith("CS"));

            Console.WriteLine(txt.IndexOf("CS"));
            Console.WriteLine(txt.LastIndexOf("s"));

            Console.WriteLine(txt.Insert(16," 2021"));

            Console.WriteLine(txt.Remove(10));
            Console.WriteLine(txt.Remove(10,2));

            Console.WriteLine(txt.Split(' ')[1]); // bölüp diziye atar.

            Console.WriteLine(txt.Replace("CSharp","C#"));
            Console.WriteLine(txt.Replace(" ",""));

            Console.WriteLine(txt.Substring(8));
            Console.WriteLine(txt.Substring(0,6));

            Console.WriteLine(txt + txxt.PadLeft(10));
            Console.WriteLine(txt + txxt.PadLeft(10,'*'));
            Console.WriteLine(txt.PadRight(50) + txxt);
            Console.WriteLine(txt.PadRight(50,'/') + txxt);
            
        }
    }
}
