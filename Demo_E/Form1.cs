using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 DBConnection dbC = new DBConnection();
 textBox3.Text = dbC.authCheck(script).ToString();
string script = $"SELECT login,password FROM cafe.users WHERE login = '{login}' AND password = '{password}'";
 */

namespace Demo_E
{
    public partial class Authorization : Form
    {

        
        

        public Authorization()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginBox.Text;
                string password = passBox.Text;
                DBConnection db = new DBConnection();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT login,password FROM users WHERE login = '{login}' AND password = '{password}';", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if(table.Rows.Count > 0 )
                {
                    MessageBox.Show("результат есть");
                }
                else
                {
                    MessageBox.Show("результата нет");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
