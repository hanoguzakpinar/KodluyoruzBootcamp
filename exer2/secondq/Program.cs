using System;

namespace secondq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

            int[] sayilar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. sayiyi giriniz:", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);

            int uzunluk = sayilar.Length;

            int suma = sayilar[0]+sayilar[1]+sayilar[2];

            int sumb = sayilar[uzunluk-1]+sayilar[uzunluk-2]+sayilar[uzunluk-3];

            Console.WriteLine("En küçük üç sayı : {0} {1} {2}  Ortalaması: {3}",sayilar[0],sayilar[1],sayilar[2],(float)suma/3);

            Console.WriteLine("En büyük üç sayı : {0} {1} {2}  Ortalaması: {3}",sayilar[uzunluk-1],sayilar[uzunluk-2],sayilar[uzunluk-3],(float)sumb/3);


        }
    }
}
