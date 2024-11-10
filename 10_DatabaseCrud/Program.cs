using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD--> Create--Read--Update--Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //String categoryName=Console.ReadLine();

            //SqlConnection connection=new SqlConnection("Data Source= DESKTOP-2955GDC\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion
            #region Ürün Ekleme İşlemi
            //string ProductName;
            //decimal ProductPrice;
            ////bool ProductStatus;
            //Console.Write("Ürün Adı: ");
            //ProductName=Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //ProductPrice =decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2955GDC\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName",ProductName);
            //command.Parameters.AddWithValue("@productPrice",ProductPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı");

            #endregion
            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2955GDC\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion
            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2955GDC\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı.");
            #endregion
            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2955GDC\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme Başarılı");
            #endregion
            Console.Read();
        }
    }
}
