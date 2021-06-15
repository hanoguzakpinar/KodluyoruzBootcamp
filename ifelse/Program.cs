using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int saat = DateTime.Now.Hour;

            if (saat>=6 && saat<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (saat>11 && saat<18)
            {
                Console.WriteLine("İyi Günler.");
            }
            else
            {
                Console.WriteLine("İyi Geceler.");
            }

            string sonuc = saat>18 ? "İyi Geceler" : saat>=6 && saat<11 ? "Günaydın" : "İyi Günler";
            Console.WriteLine(sonuc);

        }
    }
}
