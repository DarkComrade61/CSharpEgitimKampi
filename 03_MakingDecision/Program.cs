using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Veriler doğrulanamadı");
            //}
            int number;
            Console.Write("Sayıyı giriniz: ");
            number = int.Parse(Console.ReadLine());
            
            if (number == 5)
            {
                Console.WriteLine("Sayı doğru");
            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }
            Console.Read();
            #endregion
        }
    }
}
