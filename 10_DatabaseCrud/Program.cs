using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create, Read, Update, Delete

            //C# üzerinden SQL tablosuna veri aktarma
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region kategori ekleme işlemi

            //Console.Write("Eklemek istediğiniz kategoriyi adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial catalog=EgitimKampiDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);    //Tblcategory içine (CategoryName) ekliyoruz.
            //command.Parameters.AddWithValue("@p1", categoryName); //sorgu içinde p1 gönderildi bu p1 21. satırda belirtilen categoryNAme olacak.
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");

            #endregion


            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery(); //değişiklikleri kaydet ve bunu veri tabanına yansıt anlamına gelen metod.
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı!");


            #endregion


            #region Ürün Listeleme işlemi


            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //SQLden verileri c# tarafına çeken köprü görevi görür
            //DataTable dataTable = new DataTable(); //bellekte bir tablonun tutulmasını sağlar.
            //adapter.Fill(dataTable); //içini bu şekilde dolduruyoruz table'ın

            //foreach (DataRow row in dataTable.Rows) //bütün satırları dahil ettik
            //{
            //    foreach(var item in row.ItemArray) //satırların içine girdik ve ayrı sütunlardaki her bir veriyi dahil ettik.
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}





            //connection.Close();






            #endregion

            #region Ürün Silme İşlemi


            //Console.Write("Silinecek ürün ID: ");
            //int productId= int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial Catalog = EgitimKampiDb; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı.");






            #endregion

            #region Ürün güncelleme işlemi

            //Console.Write("Güncellenecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial Catalog = EgitimKampiDb; integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId = @productId", connection); //güncelleme yaparken mutlaka şartı (where) yazmamız lazım yoksa bütün kayıtları günceller.

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı!");




            #endregion

            Console.Read();


        }
    }
}
