using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DatabaseKYH
{
    public class Message
    {
        public string user;
        public string text;
        public string date;

        public Message()
        {

        }

        public Message(string user, string text, string date)
        {
            this.user = user;
            this.text = text;
            this.date = date;
        }
        public bool CreateMessage(string user, string text, string date, string site)
        {
            bool hasError = false;
            try
            {
                int count = 0;
                if (QueryMessage(ref count))
                {
                    //创建一条留言
                    NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                    "Password = postgres;Database = KYH");
                    connection.Open();

                    string sqlCommand = "Insert Into \"Message\" Values ('" + ++count + "','" + user
                        + "','" + text + "','" + date + "','" + site + "')";
                    NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch { hasError = true; }
            return !hasError;
        }

        public bool QueryMessage(ref int count)
        {
            bool hasError = false;
            try
            {
                //查询留言,获得留言个数
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Select * From \"Message\" ";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) count++;
            }
            catch { hasError = true; }
            return !hasError;
        }

        public Stack<Message> QueryMessage(string site)
        {
            Stack<Message> messages = new Stack<Message>();
            try
            {
                //查询留言,获得同一个地点所有的留言
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Select * From \"Message\" Where \"Site\"= '" + site + "'";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Message message = new Message(reader.GetString(1), reader.GetString(2), reader.GetDate(3).ToString());
                    messages.Push(message);
                }
            }
            catch { }
            return messages;
        }
    }
}
