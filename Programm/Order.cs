using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipl.Programm
{
    public partial class Order : Form
    {
        public Order()
        {
            TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();

            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlCommand command;

            string sql = "SELECT  сlients_phone, imei,  brand, model, сlients.name, orders.reason, orders.comment, orders.state  FROM orders LEFT JOIN devices ON devices_imei = imei LEFT JOIN сlients ON сlients_phone = phone LEFT JOIN users ON idusers = users_idusers LEFT JOIN status ON idorders=orders_idorders WHERE orders.idorders=@id";
            command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.oid;
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            this.data.Rows.Clear();
            while (reader.Read())
            {
                Phone.Text = reader[0].ToString();
                imeitxt.Text = reader[1].ToString();
                ProductText.Text = reader[2].ToString();
                ModelText.Text = reader[3].ToString();
                Nametext.Text = reader[4].ToString();
                Problems.Text = reader[5].ToString();
                comment.Text = reader[6].ToString();
                corpus.Text = reader[7].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
                this.data.Rows.Add(s);
            s();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            this.Close();
        }

        private void Oformit_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE devices SET brand=@id1, model=@id2 WHERE imei = @id3", db.GetConnection());
            command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = ProductText.Text;
            command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = ModelText.Text;
            command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = imeitxt.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            command = new MySqlCommand("UPDATE orders SET reason=@id1, state=@id2, comment=@id4 WHERE idorders = @id3", db.GetConnection());
            command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = Problems.Text;
            command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = corpus.Text;
            command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = DB.oid;
            command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = comment.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            command = new MySqlCommand("UPDATE orders SET reason=@id1, state=@id2, comment=@id4 WHERE idorders = @id3", db.GetConnection());
            command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = Problems.Text;
            command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = corpus.Text;
            command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = DB.oid;
            command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = comment.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            command = new MySqlCommand("UPDATE сlients SET name=@id1 WHERE  phone= @id2", db.GetConnection());
            command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = Phone.Text.Replace(" ", "").Replace("+", "").Replace("(", "").Replace(")", "");
            command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = Nametext.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idOrder = DB.oid;
            if ((textBox9.Text != "") & (textBox1.Text != ""))
            {
                DB db = new DB();
                DataTable table = new DataTable();
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO actions (`cost`, `name`, user_iduser, orders_idorders) VALUES (@id1, @id2, @id3, @id4);", db.GetConnection());
                command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = textBox9.Text;
                command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = DB.user_id;
                command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = idOrder;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                textBox1.Text = "";
                textBox9.Text = "";
                db.closeConnection();
            }
            s();

        }

        private void s(){
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlCommand command;

            string sql = "SELECT idactions as id, name as name, cost as cost, date_on as date FROM actions WHERE orders_idorders=@id UNION SELECT idstatus as id, status as name, '' as cost, date as date FROM status WHERE orders_idorders=@id ORDER BY date";

            command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.oid;
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            this.data.Rows.Clear();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            foreach (string[] s in data)
                this.data.Rows.Add(s);

            reader.Close();
            db.closeConnection();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.data.Rows[e.RowIndex].IsNewRow == false)
                {
                    DB.id_status = Convert.ToInt32(this.data.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    if (Convert.ToString(this.data.Rows[e.RowIndex].Cells["Cost"].Value)=="")
                    {
                         DB.id_status2=0;
                    }
                    else
                    {
                        DB.id_status2 = 1;
                    }
                    idstatus sh = new idstatus();
                    sh.Show();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            status("Изменён");
        }

        private void status(string status)
        {
            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table31 = new DataTable();
            MySqlCommand command = new MySqlCommand("INSERT INTO `status`(orders_idorders, users_idusers, status) VALUES(@id1, @id2, @id3); ", db.GetConnection());
            command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = DB.oid;
            command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = DB.user_id;
            command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = status;
            adapter.SelectCommand = command;
            adapter.Fill(table31);
            db.closeConnection();
            s();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status("Согласован");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            status("Готово");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status("Выдан");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            status("Закрыт");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            s();
        }
    }
}
