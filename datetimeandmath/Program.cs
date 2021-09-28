using System;

namespace datetimeandmath
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);      
            Console.WriteLine(DateTime.Now.Date);      
            Console.WriteLine(DateTime.Now.Day);      
            Console.WriteLine(DateTime.Now.Month);      
            Console.WriteLine(DateTime.Now.Year);      
            Console.WriteLine(DateTime.Now.Hour);      
            Console.WriteLine(DateTime.Now.Minute);      
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));

            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyy"));

            //Math

            Console.WriteLine(Math.Abs(-53));
            Console.WriteLine(Math.Sin(90));
            Console.WriteLine(Math.Cos(-180));
            Console.WriteLine(Math.Tan(-90));

            Console.WriteLine(Math.Ceiling(25.4));
            Console.WriteLine(Math.Floor(25.7));
            Console.WriteLine(Math.Round(25.3));
            Console.WriteLine(Math.Round(27.8));

            Console.WriteLine(Math.Max(27,8));
            Console.WriteLine(Math.Min(27,8));

            Console.WriteLine(Math.Pow(2,5));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Log10(10));
            Console.WriteLine(Math.Exp(3));
        }
    }
}
