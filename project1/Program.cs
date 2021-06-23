using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person c0ns = new Person();

            int secim = 0;
            Console.WriteLine("Hoşgeldiniz. Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");
            Console.Write("Seçiminiz: ");
            try
            {
                secim = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            SecimYap(secim);
        }

        public static void SecimYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    Person.AddPerson();
                    break;

                case 2:
                    Console.WriteLine("Numarasını silmek istediğiniz kişinin soyadını giriniz:");
                    string y = Console.ReadLine();
                    Person.Delete(y);
                    break;

                case 3:
                    break;

                case 4:
                    Person.RehberListele();
                    break;

                case 5:
                    int ch = Person.Search();
                    if (ch == 1)
                    {
                        Console.WriteLine("Aranacak isim veya soyisim:");
                        string x = Console.ReadLine();
                        Person.Search(x);
                    }
                    else if (ch == 2)
                    {
                        Console.WriteLine("Aranacak telefon:");
                        string x = Console.ReadLine();
                        Person.Search(x, 0);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim.");
                    }

                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}
