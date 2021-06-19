using System;
using System.Collections;

namespace firstq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)*

            // Negatif ve numeric olmayan girişleri engelleyin. *
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.*
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*
            ArrayList sayilar = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList notasal = new ArrayList();


            try
            {
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine("{0}. sayiyi giriniz:",i+1);
                    sayilar.Add(int.Parse(Console.ReadLine()));
                    if(Convert.ToInt32(sayilar[i])<0)
                        throw new Exception("Sayı negatif olamaz.");
                }
            }
            catch (FormatException)
            {
                throw new Exception("Geçersiz giriş.");
            }

            
            for(int i=0;i<10;i++)
            {
                int bs=0;
                for(int j=1;j<Convert.ToInt32(sayilar[i]);j++)
                {
                    if(Convert.ToInt32(sayilar[i])%j==0)
                        bs++;
                }

                if(bs==1)
                    asal.Add(sayilar[i]);
                else
                    notasal.Add(sayilar[i]);
                
                bs=0;

            }

            asal.Sort();
            notasal.Sort();

            Console.WriteLine("Asal");
            foreach (var item in asal)
                Console.WriteLine(item);
            Console.WriteLine("Asal Olmayan");
            foreach (var item in notasal)
                Console.WriteLine(item);


            int suma=0,sumb=0;
            foreach (int item in asal)
                suma +=item;
            foreach (int item in notasal)
                sumb +=item;
            
            Console.WriteLine("Asal Sayısı: {0} , Ortalaması: {1}",asal.Count,(float)suma/asal.Count);
            Console.WriteLine("Asal Olmayan Sayısı: {0} , Ortalaması: {1}",notasal.Count,(float)sumb/notasal.Count);
            


        }
    }
}
