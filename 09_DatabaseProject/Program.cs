using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net = C# programlama diline SQL yapılarını kullanabilmemize olanak sağlayan bir çerçeve.

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber; 

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            //sql bağlantısı için kullanılacak komut sqlconnection
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IV25BQJ; initial Catalog = EgitimKampiDb; integrated security = true"); //bağlantıyı oluşturduk
            connection.Open(); //bağlantıyı açtık
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //bu tablonun hangi veritabanında olduğunu bildirmek için connection verdik
            SqlDataAdapter adapter = new SqlDataAdapter(command);  //adapter nesne örneği oluşturduk.SqlDataAdapter C# tarafındaki kodlarla ve SQL sunucusu arasında köprü görevi görüyor.
            DataTable dataTable = new DataTable(); //verileri geçici ram belleğe almayı sağlar
            adapter.Fill(dataTable);

            connection.Close();

            foreach(DataRow row in dataTable.Rows)                                     //var --> bütün değişken türlerini üzerine alabilen değişken.
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            } 



            Console.Read();
        }
    }
}
