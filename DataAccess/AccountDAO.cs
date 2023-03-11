using BusinessObject;
using DBConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDAO
    {
        //Connection to database
        private string connectionString = Connection.connectionString;

        //Get all account information
        public Account GetAccount(string username)
        {
            try
            {
                //This connection auto close when it finish
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Select * From Account", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Input your code
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return null;
        }

        //Add new account to database
        public bool AddAccount(Account account)
        {
            try
            {
                //This connection auto close when it finish
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Account (Username, Password, SecurityAnswer) VALUES (@Username, @Password, @SecurityAnswer)", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Input your code
                                command.Parameters.AddWithValue("@Username", account.Username);
                                command.Parameters.AddWithValue("@Password", account.Password);
                                command.Parameters.AddWithValue("@SecurityAnswer", account.SecurityAnswer);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        //Update account in database
        public bool UpdateAccount(Account account)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Update Account set Password = @Password, SecurityAnswer = @SecurityAnswer Where Username = @Username", connection))
                    {
                        command.Parameters.AddWithValue("@Username", account.Username);
                        command.Parameters.AddWithValue("@Password", account.Password);
                        command.Parameters.AddWithValue("@SecurityAnswer", account.SecurityAnswer);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        //Delete account in database
        public bool DeleteAccount(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE From Account Where Username = @Username", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
