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

            Person.kliste.Add(p1);
            Person.kliste.Add(p2);
            Person.kliste.Add(p3);
            Person.kliste.Add(p4);
            Person.kliste.Add(p5);
        }
    }

}
