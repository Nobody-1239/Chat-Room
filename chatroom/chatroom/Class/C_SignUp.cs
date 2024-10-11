using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace chatroom
{
    internal class C_SignUp : I_SignUp
    {
        private string _connection = "Data Source = .; Initial Catalog = ChatRoom; Integrated Security = true";


        public bool SignUp(string username, string password, string Email)
        {
            SqlConnection connection = new SqlConnection(_connection);
            try
            {
                string query = "Insert Into Signup_Table (username, password, Email) values (@username, @password, @Email)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@Email", Email);

                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool Check_Repitive(string username)
        {
            string query = "SELECT COUNT(*) FROM Signup_Table WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    int userCount = (int)cmd.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }
    }
}
