using System;

namespace thirdq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. */

            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;


            Console.WriteLine("Cümle giriniz:");
            string cumle = Console.ReadLine();

            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cumle[i] == sesli[j])
                        sayac++;
                }
            }

            string[] dizi = new string[sayac];

            Console.WriteLine(sayac+" sesli harf vardır.");

            int x=0;

            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cumle[i] == sesli[j])
                    {
                        dizi[x] = cumle[i].ToString();
                         x++;
                    }
                        
                }
               
            }

            Array.Sort(dizi);

            foreach (var item in dizi)
                Console.WriteLine(item);


        }
    }
}
