using System;
using System.IO;

namespace textfile_
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("C:\\Users\\hanog\\Documents\\Projects\\csharp\\textfile_\\textfile_.txt");
            // \\ yerine @ de kullanılabilir. 
            StreamWriter sw = new StreamWriter(@"C:\Users\hanog\Documents\Projects\csharp\textfile_\textfile_.txt");
            Console.WriteLine("Yazı gir :");
            string yazi = Console.ReadLine();
            sw.Write(yazi);
            sw.Close();

            Console.WriteLine("-----------------------");
            
            FileStream fs = new FileStream(@"C:\Users\hanog\Documents\Projects\csharp\textfile_\textfile2_.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazix = sr.ReadLine();

            while ( yazix != null)
            {
                Console.WriteLine(yazix);
                yazix = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            Console.Read();
        }
    }
}
