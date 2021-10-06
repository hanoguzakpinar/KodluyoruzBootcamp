using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayiyi gir:");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi gir:");
            int s2 = int.Parse(Console.ReadLine());

            Islemler i = new Islemler();
            int toplam = i.Topla(s1,s2);
            int carp = i.Carp(s1,s2);

            Console.WriteLine("Toplam:"+toplam);
            Console.WriteLine("Carpma:"+carp);
        }
    }

    class Islemler
    {
        public int Topla(int x,int y)
        {
            return x+y;
        }

        public int Carp(int x,int y)
        {
            return x*y;
        }
    }
}
