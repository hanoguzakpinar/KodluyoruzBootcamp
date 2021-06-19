using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Users u1 = new Users(53, "OG", "Han", 2);
            u1.Yazdir();

            u1.SinifDusur();
            u1.Yazdir();

            u1.SinifDusur();
            u1.Yazdir();

            u1.SinifYukselt();
            u1.Yazdir();
            
        }
    }

    class Users
    {
        private int _no;
        private string _ad;
        private string _soyad;
        private int _sinif;

        public int No { get => _no; set => _no = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public int Sinif
        {
            get => _sinif;
            set
            {
                if (value< 1)
                {
                    Console.WriteLine("Sınıf 1'den az olamaz.");
                    this._sinif = 1;
                }
                else
                    this._sinif = value;

            }

        }

        public Users(int no, string ad, string soyad, int sinif)
        {
            _no = no;
            _ad = ad;
            _soyad = soyad;
            _sinif = sinif;
        }

        public Users() { }
        public void Yazdir()
        {
            Console.WriteLine("İsim: {0} Soyisim: {1} No: {2} Sınıf: {3}", Ad, Soyad, No, Sinif);
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
        public void SinifYukselt()
        {
            this.Sinif = this.Sinif + 1;
        }

    }
}
