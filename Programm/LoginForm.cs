using Dipl.Programm;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipl
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginPas_TextChanged(object sender, EventArgs e) // Функция Код-пороль клик
        {

        }

        private void loginPas_KeyPress(object sender, KeyPressEventArgs e) // Функция код-пороль только цифры
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void loginpas_KeyDown(object sender, KeyEventArgs e) //Команда авторизации по клавише Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
        public static class logininfo
        {
            public static int loginI = 0;
        }
        

        private void login() //Команда авторизации
        {
            String login = logint.Text;
            String pass = loginPas2.Text;
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT idusers FROM users WHERE pass = @p AND login=@u", db.GetConnection());
            command.Parameters.Add("@u", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
             adapter.Fill(table);
            db.closeConnection();
                if (table.Rows.Count > 0)
            {
                db.openConnection();
                command = new MySqlCommand("SELECT idusers FROM users WHERE pass = @p AND login=@u", db.GetConnection());
                command.Parameters.Add("@u", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
                DB.user_id = command.ExecuteScalar().ToString();
                this.Hide();
                MenuForm sh = new MenuForm();
                sh.Show();
                db.closeConnection();
            }
            else if (pass == "")
            {

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)// Активация кнопки
        {
            login();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            open.IP_MySQL = "linksys21.asuscomm.com"; // адрес сервера
            open.MySQL_username = "admin"; // имя пользователя сервера
            open.MySQL_password = "1234"; // пароль пользователя на сервере
            open.MySQL_port = "3306"; // порт
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                textBox1.Text = open.IP_MySQL;
                textBox2.Text = open.MySQL_username;
                textBox3.Text = open.MySQL_password;
                textBox4.Text = open.MySQL_port;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            open.IP_MySQL = textBox1.Text;
            open.MySQL_username = textBox2.Text;
            open.MySQL_password = textBox3.Text;
            open.MySQL_port = textBox4.Text;

            MessageBox.Show(open.IP_MySQL + "\n" + open.MySQL_username + "\n" + open.MySQL_password + "\n" + open.MySQL_port);
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
