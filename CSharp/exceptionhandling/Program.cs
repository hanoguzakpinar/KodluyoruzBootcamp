using System;

namespace exceptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
             {
                 Console.WriteLine("Sayı giriniz");
                 int number = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Girilen Sayı: {0}",number);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Hata : {0}",ex.Message.ToString());
             }
             finally
             {
                 Console.WriteLine("İşlem Tamamlandı.");
             }

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
