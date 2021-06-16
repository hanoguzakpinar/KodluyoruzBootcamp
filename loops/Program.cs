using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Gir:");
            int sayi = int.Parse(Console.ReadLine());
            for(int i=0;i<sayi;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }


            int ttoplam=0;
            int ctoplam=0;

            for(int i=1;i<=100;i++)
            {
                if(i%2==1)
                {
                    ttoplam +=i;
                }
            
                if(i%2==0)
                {
                    ctoplam +=i;
                }

            }

            Console.WriteLine("Tek Toplam :"+ttoplam);
            Console.WriteLine("Çift Toplam :"+ctoplam);




        }
    }
}
