using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminiz?");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminiz?");
            string surname = Console.ReadLine();
            Console.WriteLine("Hoşgeldin {0} {1}",name,surname);
        }
    }
}
