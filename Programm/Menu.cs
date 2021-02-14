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

namespace Dipl.Programm
{

    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)// Загрузка формы
        {
            this.WindowState = FormWindowState.Maximized;
            int user_id = int.Parse(DB.user_id);

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `name` FROM `users` WHERE `idusers`= @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = user_id;
            NameUsers2.Text = command.ExecuteScalar().ToString();
            conteiner.Text = command.ExecuteScalar().ToString();
            maskedTextBox1.Text = command.ExecuteScalar().ToString();
            db.closeConnection();

            cboColumn.Text = cboColumn.Items[0].ToString();
            Serch.Text = "";
            search();
        }

        private void Block_Click(object sender, EventArgs e)//Кнопка заблокировать
        {
            DB.user_id = null;
            this.Hide();
            LoginForm sh = new LoginForm();
            sh.Show();
        }

        private void Oformit_Click(object sender, EventArgs e) //Оформить заказ
        {
            if (Phone.Text != "" && Nametext.Text != "" && imeitxt.Text != "" && Problems.Text != "" && (radioButton.Checked || radioButton2.Checked) && corpus.Text != "" && ProductText.Text != "" && ModelText.Text != "")
            {
                String strphone = Phone.Text.Replace(" ", "").Replace("+", "").Replace("(", "").Replace(")", "");
                DB db = new DB();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT `name` FROM сlients WHERE `phone` = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = strphone;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                }
                else
                {
                    command = new MySqlCommand("INSERT INTO сlients (`phone`, `name`) VALUES (@phone, @name);", db.GetConnection());
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = strphone;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Nametext.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                DataTable table4 = new DataTable();
                command = new MySqlCommand("SELECT * FROM devices WHERE `imei` = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = imeitxt.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table4);
                if (table4.Rows.Count > 0)
                {
                }
                else
                {
                    DataTable table2 = new DataTable();
                    command = new MySqlCommand("INSERT INTO devices (`imei`, `brand`, `model`) VALUES (@imei, @brand, @model);", db.GetConnection());
                    command.Parameters.Add("@imei", MySqlDbType.VarChar).Value = imeitxt.Text;
                    command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = ProductText.Text;
                    command.Parameters.Add("@model", MySqlDbType.VarChar).Value = ModelText.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table2);
                    command = new MySqlCommand("INSERT INTO devices (`idorders`) VALUES (@id);", db.GetConnection());
                }
                DataTable table3 = new DataTable();
                command = new MySqlCommand("INSERT INTO `orders` (`users_idusers`, `сlients_phone`, `devices_imei`, `reason`, `state`, `flooded`, `comment`) VALUES (@id_user, @id_client, @id_gadgest, @prich, @hull, @flooding, @comment);", db.GetConnection());
                command.Parameters.Add("@id_user", MySqlDbType.Int32).Value = DB.user_id;
                command.Parameters.Add("@id_client", MySqlDbType.VarChar).Value = strphone;
                command.Parameters.Add("@id_gadgest", MySqlDbType.VarChar).Value = imeitxt.Text;
                command.Parameters.Add("@prich", MySqlDbType.VarChar).Value = Problems.Text;
                if (radioButton.Checked)
                {
                    command.Parameters.Add("@flooding", MySqlDbType.Int16).Value = 1;
                }
                else
                {
                    command.Parameters.Add("@flooding", MySqlDbType.Int16).Value = 0;
                }
                command.Parameters.Add("@hull", MySqlDbType.VarChar).Value = corpus.Text;
                command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment.Text;

               // ------ command.Parameters.Add("@status", MySqlDbType.VarChar).Value = ;
                adapter.SelectCommand = command;
                adapter.Fill(table3);

                command = new MySqlCommand("Select idorders FROM `orders` WHERE users_idusers=@id_user AND сlients_phone=@id_client AND devices_imei=@id_gadgest ORDER BY idorders DESC", db.GetConnection());
                command.Parameters.Add("@id_user", MySqlDbType.Int32).Value = DB.user_id;
                command.Parameters.Add("@id_client", MySqlDbType.VarChar).Value = strphone;
                command.Parameters.Add("@id_gadgest", MySqlDbType.VarChar).Value = imeitxt.Text;
                var idOrder= command.ExecuteScalar().ToString();

                DataTable table31 = new DataTable();
                command = new MySqlCommand("INSERT INTO `status`(orders_idorders, users_idusers) VALUES(@id1, @id2); ", db.GetConnection());
                command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = idOrder;
                command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = DB.user_id;
                adapter.SelectCommand = command;
                adapter.Fill(table31);
                db.closeConnection();
                MessageBox.Show("Наряд зарарегестрирован");
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void Phone_KeyUp(object sender, KeyEventArgs e) // Набор номера
        {
            String strphone = Phone.Text.Replace(" ", "").Replace("+", "").Replace("(", "").Replace(")", "");
            if (strphone.Length >= 10)
            {
                DB db = new DB();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT `name` FROM сlients WHERE `phone` = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = strphone;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Nametext.Text = command.ExecuteScalar().ToString();
                }
                else
                {

                }
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                DataTable table2 = new DataTable();
                command = new MySqlCommand("SELECT `imei` FROM devices LEFT JOIN `orders` ON `devices_imei` = `imei` WHERE `users_idusers` = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = strphone;
                adapter2.SelectCommand = command;
                adapter2.Fill(table2);

                if (table2.Rows.Count > 0)
                {
                    imeitxt.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT `model` FROM devices WHERE `imei`= @id", db.GetConnection());
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = imeitxt.Text;
                    ModelText.Text = command.ExecuteScalar().ToString();
                    command = new MySqlCommand("SELECT `brand` FROM devices` WHERE `imei`= @id", db.GetConnection());
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = imeitxt.Text;
                    ProductText.Text = command.ExecuteScalar().ToString();
                }
                db.closeConnection();
            }
        }

        private void surch_text_up(object sender, KeyEventArgs e) //набор поиска
        {
            search();
        }

        private void OnOffElements_CheckedChanged(object sender, EventArgs e) // убрать галочку
        {
            search();
        }

        private void search() // Показ базы
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlCommand command;

            string c = cboColumn.Text;
            string sql = "SELECT distinct idorders,  сlients_phone, imei,  brand, model, users.name FROM orders LEFT JOIN devices ON devices_imei = imei LEFT JOIN сlients ON сlients_phone = phone LEFT JOIN users ON idusers = users_idusers LEFT JOIN status ON idorders=orders_idorders WHERE ";
            switch (c)
            {
                case "Телефон":
                    sql = sql + "phone LIKE CONCAT(@id, '%')";
                    break;
                case "Номер заказа":
                    sql = sql + "idorders = @id";
                    break;
                case "IMEI":
                    sql = sql + "imei = @id";
                    // command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ("imei Like '" + Serch.Text + "%'");
                    break;
                case "Модель":
                    sql = sql + "model = @id";
                    // command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ("model Like '" + Serch.Text + "%'");
                    break;
                case "Приёмщик":
                    sql = sql + "users.name = @id";
                    // command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ("users.name LIKE '" + Serch.Text + "%'");
                    break;
            }

           if (OnOffElements.Checked == true)
            {
                sql = sql + " AND idorders  <> ALL (SELECT orders_idorders FROM status WHERE status = 'Выдан' OR status = 'Выдан')";
            }
            //sql = sql + " GROUP BY idorders";
            command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Serch.Text;
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            this.data.Rows.Clear();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
                this.data.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)// добавление услуги
        {
            String strphone = Phone.Text.Replace(" ", "").Replace("+", "").Replace("(", "").Replace(")", "");
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select idorders FROM `orders` WHERE users_idusers=@id_user AND сlients_phone=@id_client AND devices_imei=@id_gadgest ORDER BY idorders DESC", db.GetConnection());
            command.Parameters.Add("@id_user", MySqlDbType.Int32).Value = DB.user_id;
            command.Parameters.Add("@id_client", MySqlDbType.VarChar).Value = strphone;
            command.Parameters.Add("@id_gadgest", MySqlDbType.VarChar).Value = imeitxt.Text;
            var idOrder = command.ExecuteScalar().ToString();


            if ((idOrder != "") & (textBox9.Text != "") & textBox1.Text != "")
            {
                command = new MySqlCommand("INSERT INTO actions (`cost`, `name`, user_iduser, orders_idorders) VALUES (@id1, @id2, @id3, @id4);", db.GetConnection());
                command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = textBox9.Text;
                command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = DB.user_id;
                command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = idOrder;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                textBox1.Text = "";
                textBox9.Text="";
            }
            db.closeConnection();
        }

        private void keyup3(object sender, KeyEventArgs e)// Набор услуги
        {
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT avg(`cost`) FROM actions WHERE `name` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox9.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                textBox1.Text = command.ExecuteScalar().ToString();
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (this.data.Rows[e.RowIndex].IsNewRow == false)
                {

                    int id = Convert.ToInt32(this.data.Rows[e.RowIndex].Cells["id_other"].Value.ToString());
                    DB.oid = id;
                    Order sh = new Order();
                    sh.Show();
                }

            }
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            DB db = new DB();
            db.closeConnection();
            LoginForm sh = new LoginForm();
            sh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT idusers FROM users WHERE idusers=@id AND right1=1", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.user_id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                admin_panel sh = new admin_panel ();
                sh.Show();
            }
            else
            {
                MessageBox.Show("У вас нет прав");
            }
            db.closeConnection();
        }
    }
   }