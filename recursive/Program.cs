using System;

namespace recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Üs:");
            int us = int.Parse(Console.ReadLine());

            System.Console.WriteLine(UsAl(sayi,us));
        }

        static int UsAl(int sayi , int us)
        {
            if(us<2)
                return sayi;
            
            return UsAl(sayi,us-1)*sayi;
        }
    }
}
