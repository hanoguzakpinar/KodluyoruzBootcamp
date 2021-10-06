using System;

namespace _4thq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

            Console.WriteLine("Cümle giriniz:");
            string sentence = Console.ReadLine();

            string[] w0rds = sentence.Split(' ');

            Console.WriteLine("Kelime Sayısı:"+w0rds.Length);

            string dnm = String.Join("",w0rds);

            Console.WriteLine("Harf Sayısı:"+dnm.Length);
        }
    }
}
