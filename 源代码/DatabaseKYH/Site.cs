using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DatabaseKYH
{
    public class Site
    {
        public Stack<string> GetSitesName()
        {
            //查询所有的景点名称
            Stack<string> sites = new Stack<string>();
            NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
            "Password = postgres;Database = KYH");
            connection.Open();

            string sqlCommand = "Select site_name From eat_data";
            NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                sites.Push(reader.GetString(0));
            }

            return sites;
        }

        public void GetSitesProperties(string name, out string dish, out string price, out double latitude, out double longitude)
        {
            //查询所有的景点属性
            NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
            "Password = postgres;Database = KYH");
            connection.Open();

            string sqlCommand = "Select * From eat_data Where site_name='" + name + "'";
            NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();
            dish = reader.GetString(3);
            price = reader.GetString(4);
            latitude = reader.GetDouble(5);
            longitude = reader.GetDouble(6);
        }
    }
}
