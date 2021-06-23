using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace project1
{
    class Person
    {
        private string _isim;
        private string _soyisim;
        private string _no;

        public string Isim { get => _isim; set => _isim = value; }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public string No { get => _no; set => _no = value; }

        public static List<Person> kliste = new List<Person>();

        public Person(string isim, string soyisim, string no)
        {
            _isim = isim;
            _soyisim = soyisim;
            _no = no;
        }

        public Person()
        {
            Person p1 = new Person("Lebron", "James", "5555555555");
            Person p2 = new Person("Chris", "Paul", "4444444444");
            Person p3 = new Person("Oğuzhan", "Akpınar", "3333333333");
            Person p4 = new Person("Russel", "Westbrook", "3332222211");
            Person p5 = new Person("Devin", "Booker", "1112223388");
            Person p6 = new Person("Lebron", "James", "5555554444");

            Person.kliste.Add(p1);
            Person.kliste.Add(p2);
            Person.kliste.Add(p3);
            Person.kliste.Add(p4);
            Person.kliste.Add(p5);
        }

        public static void RehberListele()
        {
            Console.WriteLine("Telefon Rehberi :");
            Console.WriteLine("*****************");
            foreach (var item in Person.kliste)
            {
                Console.WriteLine("isim : {0} \n soyisim : {1} \n numara : {2}", item.Isim, item.Soyisim, item.No);
                Console.WriteLine("-");
            }
        }
        public static int Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) \nTelefon numarasına göre arama yapmak için: (2)");
            Console.Write("Seçiminiz: ");
            int secim = int.Parse(Console.ReadLine());

            try
            {
                switch (secim)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    default:
                        return -1;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return -1;
            }
        }
        public static void AddPerson()
        {
            Console.WriteLine("isim giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisim giriniz:");
            string soyisim = Console.ReadLine();
            Console.WriteLine("numara giriniz:");
            string numara = Console.ReadLine();

            try
            {
                Person p1 = new Person(isim, soyisim, numara);
                Person.kliste.Add(p1);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }

        }

        public static void Search(string tel, int d)
        {
            // second variable is useless.

            foreach (var item in Person.kliste)
            {
                if (item.No == tel)
                {
                    Console.WriteLine("isim : {0} \n soyisim : {1} \n numara : {2}", item.Isim, item.Soyisim, item.No);
                    Console.WriteLine("-");
                }
            }
        }
        public static void Search(string name)
        {
            foreach (var item in Person.kliste)
            {
                if (item.Isim.ToUpper() == name.ToUpper() || item.Soyisim.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine("isim : {0} \n soyisim : {1} \n numara : {2}", item.Isim, item.Soyisim, item.No);
                    Console.WriteLine("-");
                }
            }
        }

        public static void Delete(string name)
        {
            var itemToRemove = kliste.SingleOrDefault(r => r.Soyisim == name);
            if (itemToRemove == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    case 2:
                        Program.SecimYap(2);
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (1-Evet / 2-Hayır)", itemToRemove.Isim, itemToRemove.Soyisim);
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        kliste.Remove(itemToRemove);
                        Console.WriteLine("Silindi.");
                        break;
                    case 2:
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim.");
                        break;
                }
            }
        }

        public static void Update(string name)
        {
            var itemToUpdate = kliste.SingleOrDefault(r => r.Soyisim == name);
            if (itemToUpdate == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    case 2:
                        Program.SecimYap(3);
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Yeni isim değerini giriniz.:");
                string x = Console.ReadLine();
                Console.WriteLine("Yeni soyisim değerini giriniz.:");
                string y = Console.ReadLine();
                Console.WriteLine("Yeni numara değerini giriniz.:");
                string z = Console.ReadLine();

                itemToUpdate.Isim = x;
                itemToUpdate.Soyisim = y;
                itemToUpdate.No = z;

                Console.WriteLine("İşlem Tamamlandı");

                Person.RehberListele();
            }


        }

    }

}