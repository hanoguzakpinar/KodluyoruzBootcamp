using System;

namespace extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin Gir:");
            string txt = Console.ReadLine();

            Console.WriteLine(txt.MetinBuyut());
            Console.WriteLine(txt.MetinKucut());
            Console.WriteLine(txt.BoslukVarMi());
            Console.WriteLine(txt.BoslukSil());


            int[] sayilar = { 0, 5, 3, 9, 2, 6, 7, 8, 1, 15, 17, 19, 21, 22 };

            sayilar.Sirala();

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            sayilar.CiftMi();


        }
    }


    public static class Extension
    {
        public static string MetinBuyut(this string txt)
        {
            return txt.ToUpper();
        }
        public static string MetinKucut(this string txt)
        {
            return txt.ToLower();
        }

        public static bool BoslukVarMi(this string txt)
        {
            return txt.Contains(" ");
        }

        public static string BoslukSil(this string txt)
        {
            string[] dizi = txt.Split(" ");
            return string.Join("", dizi);
        }

        public static int[] Sirala(this int[] sayi)
        {
            Array.Sort(sayi);
            return sayi;
        }

        public static void CiftMi(this int[] sayi)
        {
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % 2 == 0)
                    Console.WriteLine("{0} sayısı çifttir.", sayi[i]);
                else if (sayi[i] % 2 == 1)
                    Console.WriteLine("{0} sayısı tektir.", sayi[i]);
                else
                    Console.WriteLine("Sayı saçmadır.");
            }


        }
    }
}
