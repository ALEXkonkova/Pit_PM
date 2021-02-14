using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipl
{
    public class open {
        public static string IP_MySQL; // адрес сервера
        public static string MySQL_username; // имя пользователя сервера
        public static string MySQL_password; // пароль пользователя на сервере
        public static string MySQL_port; // порт
    }
    public class DB
    {
        public static int id_status;
        public static int id_status2;
        public static int admin_panelid;
        public static string user_id; // сохранение id пользователя
        public static int oid; //номер заказа
        static String connString = "Server=" + open.IP_MySQL + ";Database= mydb ;port=" + open.MySQL_port + ";User Id=" + open.MySQL_username + ";password=" + open.MySQL_password;
        //MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; username=root; password=root; database=mydb");
        MySqlConnection connection = new MySqlConnection(connString);
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public static int order_id;
    }
}
