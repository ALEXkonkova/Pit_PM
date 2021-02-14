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
    public partial class idstatus : Form
    {
        public idstatus()
        {
            TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DB db = new DB();
            DataTable table = new DataTable();
            db.openConnection();
            if (DB.id_status2 == 0)
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM status WHERE idstatus=@id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.id_status;
                adapter.SelectCommand = command;
            }
            else {
                MySqlCommand command = new MySqlCommand("DELETE FROM actions WHERE idactions=@id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DB.id_status;
                adapter.SelectCommand = command;
            }
            adapter.Fill(table);
            db.closeConnection();
            this.Close();
        }
    }
}
