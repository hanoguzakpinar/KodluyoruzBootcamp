using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleman sayisi giriniz:");
            int elm = int.Parse(Console.ReadLine());
            int[] sayilar = new int[elm];

            for(int i=0;i<sayilar.Length;i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz :",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
