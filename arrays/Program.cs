using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleman sayisi giriniz:");
            int _count = int.Parse(Console.ReadLine());
            int[] numbers = new int[_count];

            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz :",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Sayilar");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
