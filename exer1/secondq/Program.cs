using System;

namespace secondq
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/

            Console.WriteLine("Pozitif bir N sayısı girin:");
            int N = int.Parse(Console.ReadLine());

            if (N < 0 || N == 0)
            {
                Console.WriteLine("Sayı Geçersiz");
                Environment.Exit(0);
            }

            Console.WriteLine("Pozitif bir M sayısı girin:");
            int M = int.Parse(Console.ReadLine());

            if (M < 0 || M == 0)
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

            Console.WriteLine("Eşit veya Tam Bölünen");

            for (int i = 0; i < N; i++)
            {
                if(sayilar[i]==M || M%sayilar[i]==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }


        }
    }
}
