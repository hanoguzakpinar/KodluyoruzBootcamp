using System;

namespace thirdq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen cümle içerisindeki sesli harfleri bir _array içerisinde saklayan ve _arraynin elemanlarını sıralayan programı yazınız. */

            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;

            Console.WriteLine("Cümle giriniz:");
            string sntnc = Console.ReadLine();

            for (int i = 0; i < sntnc.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (sntnc[i] == sesli[j])
                        sayac++;
                }
            }

            string[] _array = new string[sayac];

            Console.WriteLine(sayac+" sesli harf vardır.");

            int x=0;

            for (int i = 0; i < sntnc.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (sntnc[i] == sesli[j])
                    {
                        _array[x] = sntnc[i].ToString();
                         x++;
                    }  
                }
            }

            Array.Sort(_array);

            foreach (var item in _array)
                Console.WriteLine(item);
        }
    }
}
