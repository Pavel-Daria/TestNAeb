using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNAeb.Properties;

namespace TestNAeb.BaseData
{
        public class BaseData
    {
        public static Product GetClientById(int id)
        {
            Product client = new Product();
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from products where ID = @id", conn);
            command.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    client.Articul = id.ToString();
                    client.Name = reader[1].ToString();
                    client.Point = reader[2].ToString();
                    client.Price = Convert.ToInt32(reader[3]);
                    client.Discount = Convert.ToInt32(reader[4]);
                    client.Maker = reader[5].ToString(); ;
                    client.Deliver = reader[6].ToString();
                    client.Category = reader[7].ToString();
                    client.nowDiscount = Convert.ToInt32(reader[8]);
                    client.Count = Convert.ToInt32(reader[9]);
                    client.Description = reader[10].ToString();
                    client.Image = reader[11].ToString();
                }
            }

            conn.Close();
            return client;
        }
        public static void UpdateClient(Product client)
        {
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("update products SET Наименование=@Name, [Единица измерения]=@point, Стоимость=@Cost, [Размер максимально возможной скидки]=@maxDisc, Производитель=@Maker," +
                " Поставщик=@Manuf, [Категория товара]=@Categor, [Действующая скидка]=@Disc, [Кол_во_на_складе]=@count, Описание=@Descript, Изображение=@Photo  where Артикул=@id", conn);
            command.Parameters.AddWithValue("@Name", client.Name);
            command.Parameters.AddWithValue("@point", client.Point);
            command.Parameters.AddWithValue("@Cost", client.Price);
            command.Parameters.AddWithValue("@maxDisc", client.Discount);
            command.Parameters.AddWithValue("@Maker", client.Maker);
            command.Parameters.AddWithValue("@Manuf", client.Deliver);
            command.Parameters.AddWithValue("@Categor", client.Category);
            command.Parameters.AddWithValue("@Disc", client.nowDiscount);
            command.Parameters.AddWithValue("@Артикул", client.Articul);
            command.Parameters.AddWithValue("@count", client.Count);
            command.Parameters.AddWithValue("@Descript", client.Description);
            command.Parameters.AddWithValue("@Photo", client.Image);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void AddClient(Product client)
        {
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO products VALUES (@Артикул, @Name,@point,@Cost,@maxDisc,@Maker,@Manuf,@Categor,@Disc,@count,@Descript, @Photo)", conn);
            command.Parameters.AddWithValue("@Артикул", client.Articul);
            command.Parameters.AddWithValue("@Name", client.Name);
            command.Parameters.AddWithValue("@point", client.Point);
            command.Parameters.AddWithValue("@Cost", client.Price);
            command.Parameters.AddWithValue("@maxDisc", client.Discount);
            command.Parameters.AddWithValue("@Maker", client.Maker);
            command.Parameters.AddWithValue("@Manuf", client.Deliver);
            command.Parameters.AddWithValue("@Categor", client.Category);
            command.Parameters.AddWithValue("@Disc", client.nowDiscount);
            command.Parameters.AddWithValue("@count", client.Count);
            command.Parameters.AddWithValue("@Descript", client.Description);
            command.Parameters.AddWithValue("@Photo", client.Image);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteClientById(int id)
        {
            SqlConnection conn = new SqlConnection(Connection.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("DELETE FROM products  WHERE products.ID=@id", conn);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
