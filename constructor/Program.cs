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
        private string _name;
        private string _surname;
        private int _grade;

        public int No { get => _no; set => _no = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Grade
        {
            get => _grade;
            set
            {
                if (value< 1)
                {
                    Console.WriteLine("Sınıf 1'den az olamaz.");
                    this._grade = 1;
                }
                else
                    this._grade = value;

            }

        }

        public Users(int no, string ad, string soyad, int sinif)
        {
            _no = no;
            _name = ad;
            _surname = soyad;
            _grade = sinif;
        }

        public Users() { }
        public void Yazdir()
        {
            Console.WriteLine("İsim: {0} Soyisim: {1} No: {2} Sınıf: {3}", Name, Surname, No, Grade);
        }

        public void SinifDusur()
        {
            this.Grade = this.Grade - 1;
        }
        public void SinifYukselt()
        {
            this.Grade = this.Grade + 1;
        }

    }
}
