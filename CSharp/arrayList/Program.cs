using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // list.Add("Name");
            // list.Add(96);
            // list.Add(true);
            // list.Add('C');

            // Console.WriteLine(list[2]);

            // foreach (var item in list)
            //     Console.WriteLine(item);

            Console.WriteLine("***************");
            //AddRange - Eleman Ekleme Collection Türünde.

            // string[] chars = {"ABC","DEF","GGX","XYZ"};
            List<int> nmr = new List<int>() { 0, 5, 6, 7, 8, 9 };
            // list.AddRange(chars);
            list.AddRange(nmr);

            foreach (var item in list)
                Console.WriteLine(item);

            // Sort - Sıralama - Aynı Tür Elemanlar
            Console.WriteLine("***************");
            list.Sort();
            foreach (var item in list)
                Console.WriteLine(item);

            // Binary Search - Önce Sıralama Yapılması Gerekli
            Console.WriteLine("***************");
            Console.WriteLine(list.BinarySearch(5));

            // Reverse
            Console.WriteLine("***************");
            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);

            // Clear
            Console.WriteLine("***************");
            list.Clear();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
