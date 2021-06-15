using System;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
             {
                 Console.WriteLine("Sayi giriniz");
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Girilen Sayı: {0}",sayi);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Hata : {0}",ex.Message.ToString());

             }
             finally
             {

                 Console.WriteLine("İşlem Tamamlandı.");
             }

        //////////////////////////////////////////////////////////////////////

        try
        {
            int number = int.Parse(null);
        }
        catch (ArgumentNullException msg)
        {
            Console.WriteLine("Hata : {0}",msg.Message.ToString()); 
        }
        catch(FormatException msg)
        {
            Console.WriteLine("Hata : {0}",msg.Message.ToString());
        }
        catch(OverflowException msg)
        {
            Console.WriteLine("Hata : {0}",msg.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı.");

        }

        }
    }
}
