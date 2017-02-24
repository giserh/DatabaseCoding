using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DatabaseKYH
{
    public class User
    {
        string user, password, email;
        int sex;

        //初始化用户表
        public User()
        {

        }

        public User(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public User(string user, string password, string sex, string email)
        {
            this.user = user;
            this.password = password;
            this.email = email;
            if (sex == "男") this.sex = 1;
            else this.sex = 0;
        }

        public void GetUserInformation(out string user, out string password, out string sex, out string email)
        {
            user = this.user;
            password = this.password;
            email = this.email;
            if (this.sex == 1) sex = "男";
            else sex = "女";
        }

        //注册用户
        public bool CreateUser()
        {
            bool hasError = false;
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Insert Into \"User\" Values ('" + user
                    + "','" + password + "'," + sex + ",'" + email + "')";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                command.ExecuteNonQuery();
            }
            catch { }
            return !hasError;
        }

        //修改用户
        public bool ModifyUser(string userPassword, string sex, string email)
        {
            bool hasError = false;
            try
            {
                int userSex = 0;
                if (sex == "男") userSex = 1;
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                    "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Update \"User\" Set \"Password\"='" + userPassword
                    + "',\"Sex\"=" + userSex + ",\"Email\"='" + email + "' Where \"Name\"='" + user + "'";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);

                command.ExecuteNonQuery();

                this.password = userPassword;
                if (sex == "男") this.sex = 1;
                else this.sex = 0;
                this.email = email;
            }
            catch { hasError = true; }
            return !hasError;
        }

        //获取用户信息
        public bool GetUserInformation(out string userPassword)
        {
            bool hasError = false;
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Select * From \"User\" Where \"Name\"='" + user + "'";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();

                this.user = reader.GetString(0);
                this.password = reader.GetString(1);
                this.sex = reader.GetInt32(2);
                this.email = reader.GetString(3);
            }
            catch { hasError = true; }
            userPassword = password;

            return !hasError;
        }

        public bool DeleteUser()
        {
            //注销用户
            bool hasError = false;
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server = 139.196.243.189; Port = 5432; UserId = postgres; " +
                "Password = postgres;Database = KYH");
                connection.Open();

                string sqlCommand = "Delete From \"User\" Where \"Name\"='" + this.user + "'";
                NpgsqlCommand command = new NpgsqlCommand(sqlCommand, connection);
                command.ExecuteNonQuery();
            }
            catch { hasError = true; }
            return !hasError;
        }
    }
}
