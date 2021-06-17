using System;

namespace thirdq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

            Console.WriteLine("Pozitif bir N sayısı girin:");
            int N = int.Parse(Console.ReadLine());

            if (N < 0 || N == 0)
            {
                Console.WriteLine("Sayı Geçersiz");
                Environment.Exit(0);
            }

            string[] w0rds = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Kelime girin:");
                w0rds[i] = Console.ReadLine();
            }

            Console.WriteLine("Kelimeler:");

            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine(w0rds[i]);
            }

        }
    }
}
