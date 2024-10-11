using System;
using System.Data.SqlClient;

namespace chatroom
{
    internal class C_Login : I_Login
    {
        private string _connection = "Data Source = .; Initial Catalog = ChatRoom; Integrated Security = true";

        public bool Login(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Signup_Table WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int userCount = (int)cmd.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }
    }
}
