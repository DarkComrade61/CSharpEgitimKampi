using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-->Listele,ekle,sil,güncelle
            //Void
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet YILDIRIM");
            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Fatih", "Çağlayan");
            //CustomerCard("Mehmet", "Yıldız");
            #endregion
            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void Sum(int sayi1,int sayi2,int sayi3)
            //{
            //    int result = sayi1 + sayi2 + sayi3;
            //    Console.WriteLine(result);
            //}
            //Sum(5,3,6);
            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{ return "Buse Yıldız"; }
            //CustomerName();
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());
            #endregion
            #region Geriye Değer Döndüren Parametreli Metotlar
            //string CountryCard(string countryName,string capital,string flagColor)
            // {
            //     string cardInfo="Ülke: "+countryName+" - Başkent: "+capital+" - Bayrak Rengi "+flagColor;
            //     return cardInfo;
            // }
            // string x, y, z;
            // Console.Write("Ülke adını giriniz: ");
            // x = Console.ReadLine();
            // Console.Write("Başkenti giriniz: ");
            // y = Console.ReadLine();
            // Console.Write("Bayrak rengini giriniz: ");
            // z = Console.ReadLine();

            // Console.WriteLine(CountryCard(x, y, z));
            // Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion
            #region Geriye Değer Döndüren İnt Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{ int result= number1 + number2; 
            //return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));
            #endregion
            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli Öğrenci sınavı geçti "+ "Ortalama: "+result;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali",25,41,55));
            #endregion
            Console.Read();
        }
    }
}
