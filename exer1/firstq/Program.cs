using System;

namespace firstq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Pozitif bir sayı girin:");
            int N = int.Parse(Console.ReadLine());

            if (N < 0 || N == 0)
            {
                Console.WriteLine("Sayı Geçersiz");
                Environment.Exit(0);
            }

            int[] sayilar = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Sayı girin:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (sayilar[i] % 2 == 0)
                 Console.WriteLine(sayilar[i]+" çifttir.");
            }
        }
    }
}

