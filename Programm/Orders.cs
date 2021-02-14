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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            int id = DB.order_id;
            TextBoxId_order.Text = id.ToString();

            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT сlients_phone, brand, model, devices_imei, reason, data_on, status.status, comment, status.date, users.name FROM orders left JOIN devices ON devices_imei=imei LEFT JOIN status On status.orders_idorders=idorders LEFT JOIN users ON idusers=orders.users_idusers WHERE idorders=@id ORDER BY status.date DESC LIMIT 1", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.order_id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            MySqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();


            maskedTextBox7.Text = (string)dataReader["сlients_phone"];
            maskedTextBox17.Text = (string)dataReader["brand"] + " " + (string)dataReader["model"];
            maskedTextBox8.Text = (string)dataReader["devices_imei"];
            maskedTextBox9.Text = (string)dataReader["reason"];
            maskedTextBox10.Text = dataReader["data_on"].ToString();
            maskedTextBox13.Text = (string)dataReader["status"].ToString();
            comment.Text = (string)dataReader["comment"];
            maskedTextBox12.Text = (string)dataReader["name"].ToString();

            history();

        }

        private void history()
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;
            command = new MySqlCommand();

            string c = cboColumn.Text;

            string sql = "SELECT service.name, components.name, actions.cost, users.name, actionscol FROM actions LEFT JOIN components ON components_idcomponents = idcomponents LEFT JOIN service ON idservice=service_idservice LEFT JOIN users ON idusers=users_idusers Where orders_idorders=@id UNION SELECT status, ' ', ' ', users.name, date FROM status LEFT Join users ON users_idusers=idusers WHERE orders_idorders=@id ORDER BY actionscol";

            command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.order_id; ;


            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
