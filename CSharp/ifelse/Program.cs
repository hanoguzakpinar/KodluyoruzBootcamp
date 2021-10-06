using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int _hour = DateTime.Now.Hour;

            if (_hour>=6 && _hour<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (_hour>11 && _hour<18)
            {
                Console.WriteLine("İyi Günler.");
            }
            else
            {
                Console.WriteLine("İyi Geceler.");
            }

            string sonuc = _hour>18 ? "İyi Geceler." : _hour>=6 && _hour<11 ? "Günaydın." : "İyi Günler.";
            Console.WriteLine(sonuc);
        }
    }
}
