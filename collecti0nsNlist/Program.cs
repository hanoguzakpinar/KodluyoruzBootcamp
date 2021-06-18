using System;
using System.Collections.Generic;

namespace collecti0nsNlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(53);
            nums.Add(34);
            nums.Add(96);
            nums.Add(11);
            nums.Add(17);

            List<string> txts = new List<string>();
            txts.Add("Oğuz");
            txts.Add("Han");
            txts.Add("Ak");
            txts.Add("Pınar");
            txts.Add("Beylikdüzü");


            // Count  - Eleman sayısı

            Console.WriteLine(nums.Count);
            Console.WriteLine(txts.Count);

            // Yazdırma

            foreach (int item in nums)
                Console.WriteLine(item);

            foreach (string item in txts)
                Console.WriteLine(item);

            // Alternatif Yazdırma
            nums.ForEach(item => Console.WriteLine(item));
            txts.ForEach(item => Console.WriteLine(item));

            // Eleman Silme
            nums.Remove(53);
            txts.Remove("Ak");
            // Index ile Silme
            nums.RemoveAt(0);
            txts.RemoveAt(1);

            nums.ForEach(item => Console.WriteLine(item));
            txts.ForEach(item => Console.WriteLine(item));

            // Arama

            if(txts.Contains("Pınar"))
                Console.WriteLine("Bulundu");
            else
                Console.WriteLine("Bulunamadı");

            // Elemana Göre Index Öğrenme

            Console.WriteLine(txts.BinarySearch("Beylikdüzü"));

            // Dizi 2 Array Convert

            string[] dnm = {"ABC","DEF","GHX","YZW"};
            List<string> dnm2 = new List<string>(dnm);

            // Temizleme

            dnm2.Clear();


            List<Users> kul = new List<Users>();

            Users kk = new Users();
            kk.Ad = "Lebron";
            kk.Soyad="James";
            kk.Yas=36;

            Users kkk = new Users();
            kkk.Ad = "Chris";
            kkk.Soyad="Paul";
            kkk.Yas=36;

            kul.Add(kk);
            kul.Add(kkk);

            List<Users> newone = new List<Users>();
            // Alternatif
            newone.Add(new Users(){
                Ad = "Russel",
                Soyad="Westbrook",
                Yas=32
            }
            );

            foreach (var item in kul)
            {
                System.Console.WriteLine("Ad: "+item.Ad+" Soyad: "+item.Soyad+" Yaş: "+item.Yas);
            }








        }
    }

    public class Users
    {
        private string ad;
        private string soyad;
        private int yas;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
