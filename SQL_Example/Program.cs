using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = JPG\SQLEXPRESS; Initial Catalog = Example; User ID =JaydeepGodase; Password=; Trusted_Connection=Yes;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Debug.WriteLine("Connected to the Server");
            SqlCommand cmd = connection.CreateCommand();    
            cmd.Connection = connection;    
            cmd.CommandType=CommandType.Text;
            cmd.CommandText = "Select * from dbo.people";
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Debug.WriteLine(reader.GetString(1)+"-"+reader.GetString(2));
                }
            }

            connection.Close();
        }
    }
}
