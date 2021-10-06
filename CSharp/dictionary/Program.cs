using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(10, "İsim");
            list.Add(20, "İsim2");
            list.Add(30, "İsim3");
            list.Add(40, "İsim4");

            Console.WriteLine(list[10]);
            foreach (var item in list)
                Console.WriteLine(item);


            Console.WriteLine("***************");
            Console.WriteLine("Count:" + list.Count);

            Console.WriteLine("************");
            Console.WriteLine(list.ContainsKey(10));
            Console.WriteLine(list.ContainsValue("İsim"));

            Console.WriteLine("************");

            list.Remove(40);
            foreach (var item in list)
                Console.WriteLine(item.Value);

            Console.WriteLine("************ Keys");
            foreach (var item in list.Keys)
                Console.WriteLine(item);


            Console.WriteLine("************ Values");
            foreach (var item in list.Values)
                Console.WriteLine(item);
        }
    }
}
