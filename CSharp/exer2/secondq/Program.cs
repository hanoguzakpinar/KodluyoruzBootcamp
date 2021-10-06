using System;

namespace secondq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

            int[] numbers = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz:", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int _length = numbers.Length;

            int suma = numbers[0]+numbers[1]+numbers[2];

            int sumb = numbers[_length-1]+numbers[_length-2]+numbers[_length-3];

            Console.WriteLine("En küçük üç sayı : {0} {1} {2}  Ortalaması: {3}",numbers[0],numbers[1],numbers[2],(float)suma/3);

            Console.WriteLine("En büyük üç sayı : {0} {1} {2}  Ortalaması: {3}",numbers[_length-1],numbers[_length-2],numbers[_length-3],(float)sumb/3);
        }
    }
}
