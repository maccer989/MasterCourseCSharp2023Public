using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class UserManager
    {
        private readonly string connectionString;

        public UserManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int CreateUser(string firstName, string lastName, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Users (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email); SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);

                int newUserID = Convert.ToInt32(command.ExecuteScalar());
                return newUserID;
            }
        }

        public bool UpdateUser(int userID, string firstName, string lastName, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE ID = @UserID";
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@UserID", userID);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Users WHERE ID = @UserID";
                command.Parameters.AddWithValue("@UserID", userID);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public User GetUserByID(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users WHERE ID = @UserID";
                command.Parameters.AddWithValue("@UserID", userID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User
                    {
                        ID = (int)reader["ID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"]
                    };
                    return user;
                }

                return null;
            }
        }
    }
}
