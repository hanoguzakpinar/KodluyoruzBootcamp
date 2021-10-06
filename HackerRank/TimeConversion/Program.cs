using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string hour = Console.ReadLine();

            string[] values = hour.Split(":");

            string meridiem = values[2].Substring(2, 2);

            values[2] = values[2].Substring(0, 2);

            if (meridiem == "PM" && int.Parse(values[0]) != 12)
            {
                values[0] = (int.Parse(values[0]) + 12).ToString();
            }
            if (meridiem == "AM" && values[0]=="12")
            {
                values[0] = "00";
            }

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i]);
                if(i!=2)
                {
                    Console.Write(":");
                }
            }
        }
    }
}
