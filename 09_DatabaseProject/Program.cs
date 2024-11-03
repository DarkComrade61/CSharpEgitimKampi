using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("1-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber=Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

           
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2955GDC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory",connection);
            SqlDataAdapter da=new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.Read();
        }
    }
}
