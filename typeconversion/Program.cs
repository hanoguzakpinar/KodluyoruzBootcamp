using System;

namespace typeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float a; int b = 25; a = b;
            short x = 10; int y; y = x;
            int ax; ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ax);
            int ac; ac = int.Parse(Console.ReadLine());
            Console.WriteLine(ac);
            long xq = long.Parse(Console.ReadLine());
            Console.WriteLine(xq);
            double sayi = 3.45; int ap = (int)sayi;
            Console.WriteLine(sayi);
        }
    }
}
