using System;

namespace methodoverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler xx = new Islemler();

            string sayi = "53";

            bool sonuc = int.TryParse(sayi, out int CikanSayi);

            if (sonuc)
            {
                xx.EkranaYaz("Başarılı");
                xx.EkranaYaz(CikanSayi);
            }
            else
            {
                xx.EkranaYaz("Başarısız");
            }

        }
    }

    class Islemler
    {
        public void EkranaYaz(int sayi)
        {
            Console.WriteLine(sayi);
        }

        public void EkranaYaz(string txt)
        {
            Console.WriteLine(txt);
        }
        

    }
}
