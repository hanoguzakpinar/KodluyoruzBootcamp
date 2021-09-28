using System;
using System.Linq;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("İsminiz?");
             string name = Console.ReadLine();
             Console.WriteLine("Soyisminiz?");
             string surname = Console.ReadLine();
             Console.WriteLine("Hoşgeldin {0} {1}",name,surname);*/
            /*
                        string str = "never odd or even";
                        string degerx = string.Concat(str.Where(c => !char.IsWhiteSpace(c)));
                        string degery = string.Concat(str.Where(c => !char.IsWhiteSpace(c)));

                        char[] deger = degerx.ToCharArray();
                        char[] deger2 = degery.ToCharArray();

                        bool isPalid=true;
                        int j = deger2.Length-1;

                        for(int i=0;i<deger.Length;i++)
                        {
                            if(deger[i]!=deger2[j])
                            {
                                isPalid=false;
                            }
                            j--;
                        }

                        Console.WriteLine(isPalid);*/


            /*
            using System;

class MainClass {

  public static string CamelCase(string str) {

    char[] deger = str.ToCharArray();

    deger[0] = char.ToLower(deger[0]);

    for(int i=1;i<deger.Length;i++)
    {
      if(deger[i-1]==' ' || deger[i-1]=='*'|| deger[i-1]=='-'||deger[i-1]=='%')
      {
        deger[i-1] = char.ToUpper(deger[i]);
        deger[i] = '?';

      }
      else
      {
        deger[i] = char.ToLower(deger[i]);
      }
    }

    string str2 = new string(deger);

    str2 = str2.Replace("?",string.Empty);

    return str2;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CamelCase(Console.ReadLine()));
  } 

}
*/
            var namex = "sa";

            Console.WriteLine(namex);

        }
    }
}
