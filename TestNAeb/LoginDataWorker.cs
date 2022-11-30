using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TestNAeb
{
    public static class LoginDataWorker
    {
        public static bool CheckIsLogin(string login, string pass)
        {
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();

                string command = QueryGenerator.GetLoginQuery();
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetValue(0));
                        string remoteLogin = reader.GetValue(1) as string;
                        string remotePass = reader.GetValue(2) as string;
                        string remoteRole = reader.GetValue(3) as string;
                        string fio = reader.GetValue(4) as string;

                        if (login == remoteLogin && pass == remotePass)
                        {
                            AuthorizedUser.SetUser(id, fio, remoteRole);

                            return true;
                        }
                    }
                }

                connection.Close();
            }

            return false;
        }
    }
}
