using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestNAeb
{
    public static class ProductsDataWorker
    {
        private static string _command = "";

        public static List<Product> GetProductsListing()
        {
            _command = QueryGenerator.GetProductsQuery();

            return GetProducts();
        }

        public static List<Product> GetProductListSorted(string sortValue)
        {
            _command = QueryGenerator.GetSortingQuery(sortValue);

            return GetProducts();
        }

        public static List<Product> GetProductListFiltered(string filterValue)
        {
            _command = QueryGenerator.GetFilterQuery(filterValue);

            return GetProducts();
        }

        public static List<Product> GetProductListSearched(string searchValue)
        {
            _command = QueryGenerator.GetSearchingQuery(searchValue);

            return GetProducts();
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(_command, connection);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string image = reader.GetValue(0) as string;
                        string name = reader.GetValue(1) as string;
                        string description = reader.GetValue(2) as string;
                        string maker = reader.GetValue(3) as string;
                        int price = Convert.ToInt32(reader.GetValue(4));
                        int count = Convert.ToInt32(reader.GetValue(5));

                        Product product = new Product(image, name, description, maker, price, count);
                        products.Add(product);
                    }
                }

                connection.Close();
            }

            return products;
        }

        public static List<string> GetMakers()
        {
            List<string> makers = new List<string>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                string command = QueryGenerator.GetMakersQuery();
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maker = reader.GetValue(0) as string;
                        makers.Add(maker);
                    }
                }

                connection.Close();
            }

            return makers;
        }
    }
}
