﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            ////Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            ////int finishValue=int.Parse(Console.ReadLine());
            ////Console.Write("Lütfen ekrana yazılmasını istediğiniz kelimeyi giriniz: ");
            ////string yazilacakKelime=Console.ReadLine();
            ////for (int i = 1; i <=finishValue; i++)
            ////{
            ////    Console.WriteLine(yazilacakKelime);
            ////}
            #endregion
            #region For Döngüsü ile Karar Yapıları
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue = totalValue + i;
            //}
            //Console.WriteLine(totalValue);
            //int totalValue = 0;
            //for (int i = 1; i <20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //               }
            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);
            //int count=0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium = bacterium * 2;
            //    Console.WriteLine(i+". saat sonunda bakteri sayısı: "+bacterium);
            //}
            #endregion
            #region While Döngüsü
            //While(şart)
            //{
            //işlemler
            //}
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}
            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //int sum=0;
            //int i = 1;
            //while (i<=10)
            //{
            //    sum=sum+i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion
            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //Console.Write("Sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //hundreds = number / 100;
            //tens= (number % 100)/10;
            //sum = ones + tens + hundreds;
            //Console.Write(sum);
            #endregion
            Console.Read();
        }
    }
}
