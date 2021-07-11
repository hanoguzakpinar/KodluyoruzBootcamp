using System;

namespace random_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Random sayi = new Random();
            x = sayi.Next(0,25);

            Console.WriteLine("Sayiyi tahmin et");
            Console.WriteLine("1. İpucu : {0} , 2. İpucu : {1} , 3. İpucu : {2}",Math.Sqrt(x),Math.Pow(x,2),Math.Pow(x,3));
            
            Console.WriteLine("\nTahmin gir:");
            int tahmin = int.Parse(Console.ReadLine());

            if(tahmin==x)
            {
                Console.WriteLine("Tahmin başarılı.");
            }
            else
            {
                Console.WriteLine("Tahmin başarısız.");
            }

            Console.ReadKey();
        }
    }
}
