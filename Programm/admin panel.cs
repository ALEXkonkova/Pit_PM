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
    public partial class admin_panel : Form
    {
        public int id;
        public admin_panel()
        {
            InitializeComponent();
            s();
        }

        private void s()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command;

            string sql = "SElect idusers, name, surname, patronymic, right1 FROM users";
            command = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            this.data.Rows.Clear();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString();
                if (reader[4].ToString() == "1")
                {
                    data[data.Count - 1][2] = "Администратор";
                }
                else
                {
                    data[data.Count - 1][2] = " ";
                }

            }
            foreach (string[] s in data)
                this.data.Rows.Add(s);

            reader.Close();
            db.closeConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command;
            if (e.RowIndex >= 0)
                {
                    if (this.data.Rows[e.RowIndex].IsNewRow == false)
                    {
                         DB.admin_panelid = Convert.ToInt32(this.data.Rows[e.RowIndex].Cells["id0"].Value);
                         string sql = "SElect * FROM users WHERE idusers =@id";
                         command = new MySqlCommand(sql, db.GetConnection());
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.admin_panelid;
                    MySqlDataReader reader = command.ExecuteReader();
                    this.data.Rows.Clear();
                    while (reader.Read())
                    {
                        textBox1.Text = reader[1].ToString();
                        Nametext.Text = reader[2].ToString();
                        textBox2.Text = reader[3].ToString();
                        textBox3.Text = reader[5].ToString();
                        textBox4.Text = reader[6].ToString();
                        if (reader[4].ToString() == "1")
                        {
                            rb.Checked = true;
                        }
                        else
                        {
                            rb.Checked = false;
                        }

                    }
                    reader.Close();
                    db.closeConnection();
                    s();
                }
                 }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            if (DB.admin_panelid == 0)
            {
                db.openConnection();
                string sql = "Select *  From users WHERE  login=@id";
                command = new MySqlCommand(sql, db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox3.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();
                if(table.Rows.Count == 0)
                {
                    db = new DB();
                    table = new DataTable();
                    adapter = new MySqlDataAdapter();
                    db.openConnection();
                    sql = "INSERT INTO `users` ( `name`, `surname`, `patronymic`, `right1`, `login`, `pass`) VALUES ( @id1, @id2, @id3, @id4, @id5, @id6);";
                    command = new MySqlCommand(sql, db.GetConnection());
                    command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = textBox1.Text;
                    command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = Nametext.Text;
                    command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = textBox2.Text;
                    if (rb.Checked == true)
                    {
                        command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = "1";
                    }
                    else
                    {
                        command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = "0";
                    }
                    command.Parameters.Add("@id5", MySqlDbType.VarChar).Value = textBox3.Text;
                    command.Parameters.Add("@id6", MySqlDbType.VarChar).Value = textBox4.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Такой логин существует");
                }
                
            }
            else
              {
                db = new DB();
                table = new DataTable();
                adapter = new MySqlDataAdapter();
                db.openConnection();
                string sql = "UPDATE `users` SET `name`=@id1,`surname`=@id2,`patronymic`=@id3,`right1`=@id4,`login`=@id5,`pass`=@id6 WHERE idusers=@id";
                command = new MySqlCommand(sql, db.GetConnection());
                command.Parameters.Add("@id1", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@id2", MySqlDbType.VarChar).Value = Nametext.Text;
                command.Parameters.Add("@id3", MySqlDbType.VarChar).Value = textBox2.Text;
                if (rb.Checked == true)
                {
                    command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = "1";
                }
                else
                {
                    command.Parameters.Add("@id4", MySqlDbType.VarChar).Value = "0";
                }
                command.Parameters.Add("@id5", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@id6", MySqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.admin_panelid;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();
            }
            s();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DB.admin_panelid = 0;
            radioButton1.Checked = true;
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            Nametext.Text = "";
        }
    }
}
