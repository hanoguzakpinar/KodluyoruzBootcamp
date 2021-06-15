using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1,s2;
            
            try
            {
                Console.WriteLine("Birinci sayiyi giriniz:");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci sayiyi giriniz:");
                s2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException msg)
            {
                Console.WriteLine("Hata :" + msg.Message.ToString());
                throw;
            }

            Console.WriteLine("Yapılacak İşlemi Giriniz: ( + - / *)");
            char islem = char.Parse(Console.ReadLine());

            int sonuc;

            switch (islem)
            {
                case '+':
                    sonuc = s1 + s2;
                    Console.WriteLine("Sonuç:" + sonuc);
                    break;
                case '-':
                    sonuc = s1 - s2;
                    Console.WriteLine("Sonuç:" + sonuc);
                    break;
                case '*':
                    sonuc = s1 * s2;
                    Console.WriteLine("Sonuç:" + sonuc);
                    break;
                case '/':
                    float sonucx = (float)s1 / s2;
                    Console.WriteLine("Sonuç:" + sonucx);
                    break;
                default:
                    Console.WriteLine("Seçim Hatalı.");
                    break;
            }


        }
    }
}
