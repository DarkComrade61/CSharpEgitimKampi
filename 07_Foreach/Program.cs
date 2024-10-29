using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)
            //1-Değişken türü
            //2-Değişken adı
            //3-In
            //4-Liste, Koleksiyon, Dizi
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in numbers)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total=total+i;
            //}
            //Console.WriteLine(total);
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //string word = "Merhaba";
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Örnek Sınav Sistemi Uygulaması
            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var? : ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için üç sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz:");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult = totalExamResult + value;//notları topluyoruz.
            //    }
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            ////Sınav Ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //öğrencilerin ortalamaları ve geçip kalma durumları
            //    if (studentExamAvg[i]>=50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //}
            
            #endregion
            Console.Read();
        }
    }
}
