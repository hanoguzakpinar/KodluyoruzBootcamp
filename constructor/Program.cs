using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Users u1 = new Users(53,"OG","Han","hanOG");

            u1.Yazdir();
        }
    }

    class Users
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string UName;

        public Users(int no, string ad, string soyad, string uname)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.UName =uname;
        }
        
        public Users(){}

        public void Yazdir()
        {
            Console.WriteLine("İsim: {0} Soyisim: {1} No: {2} Username: {3}",Ad,Soyad,No,UName);
        }

    }
}
