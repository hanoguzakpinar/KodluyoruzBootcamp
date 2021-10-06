using System;

namespace staticExmpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpma: " + Ops.Carp(5, 5));
            Console.WriteLine("Toplama: " + Ops.Topla(5, 5));
            Console.WriteLine("Çıkarma: " + Ops.Cikar(5, 5));

            Console.WriteLine("Çalışan Sayısı : {0}", Worker.CalisanSayi);
            Worker wrk = new Worker("Oğuz", "Han");
            Console.WriteLine("Çalışan Sayısı : {0}", Worker.CalisanSayi);
            Worker wrkx = new Worker("Han", "Akpınar");
            Console.WriteLine("Çalışan Sayısı : {0}", Worker.CalisanSayi);
        }
    }

    // Static Class
    static class Ops
    {
        public static int Topla(int x1, int x2)
        {
            return x1 + x2;
        }
        public static int Cikar(int x1, int x2)
        {
            return x1 - x2;
        }
        public static int Carp(int x1, int x2)
        {
            return x1 * x2;
        }
    }

    class Worker
    {
        private static int calisanSayi;
        private string _isim;
        private string _soyisim;

        public static int CalisanSayi { get => calisanSayi; set => calisanSayi = value; }
        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }

        public Worker(string isim, string soyisim)
        {
            this._isim = isim;
            this._soyisim = soyisim;
            calisanSayi++;
        }

        static Worker()
        {
            calisanSayi = 0;
        }
    }
}
