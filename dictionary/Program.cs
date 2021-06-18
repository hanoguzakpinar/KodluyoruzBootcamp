using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> liste = new Dictionary<int, string>();
            liste.Add(10, "İsim");
            liste.Add(20, "İsim2");
            liste.Add(30, "İsim3");
            liste.Add(40, "İsim4");

            Console.WriteLine(liste[10]);
            foreach (var item in liste)
                Console.WriteLine(item);


            Console.WriteLine("***************");
            Console.WriteLine("Count:" + liste.Count);

            Console.WriteLine("************");
            Console.WriteLine(liste.ContainsKey(10));
            Console.WriteLine(liste.ContainsValue("İsim"));

            Console.WriteLine("************");

            liste.Remove(40);
            foreach (var item in liste)
                Console.WriteLine(item.Value);

            Console.WriteLine("************ Keys");
            foreach (var item in liste.Keys)
                Console.WriteLine(item);


            Console.WriteLine("************ Values");
            foreach (var item in liste.Values)
                Console.WriteLine(item);
        }
    }
}
