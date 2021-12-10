using System;

namespace buyukucuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 50)
            {
                Console.WriteLine(a + " sayısı 50'den büyük. ");
            }
            else if (a ==  50)
            {
                Console.WriteLine(a + " = 50  ");
            }
            else if  (a < 50)       
            {
                Console.WriteLine(a + " sayısı 50'den küçük. ");
            }
        }
    }
}
