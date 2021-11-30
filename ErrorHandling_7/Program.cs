using System;

namespace ErrorHandling_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = Int32.Parse("-2000000000000");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Bos deger girdiniz ");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir sayi girdiniz");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi");
            }
        }
    }
}