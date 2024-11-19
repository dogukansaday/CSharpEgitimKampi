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
            //Crud-->Crate-read-update-delete
            Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();


            Console.WriteLine("----------------------------------------");
            #region kategori ekleme işlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName =Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JIMDJ9G; initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-JIMDJ9G; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus)values(@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı!");

            #endregion


            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-JIMDJ9G; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}
            //connection.Close();

            #endregion

            #region Ürün silme işlemi

            //Console.WriteLine("Silinecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-JIMDJ9G; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi tamamlanmıştır");





            #endregion

            #region Güncelleme İşlemi
            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-JIMDJ9G; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //Console.Write("Güncellenecek Ürün ıd: ");
            //int productId = int.Parse(Console.ReadLine());


            //Console.Write("Güncellenedek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı");
            //decimal price = int.Parse(Console.ReadLine());

            //SqlCommand command = new SqlCommand("update TblProduct set  ProductName=@productName, price=@productPrice, Where productId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", price);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı");
            #endregion





            Console.Read();
        }
    }
}
