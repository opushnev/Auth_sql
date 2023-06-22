using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Auth_sql
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
  
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string connStr = Properties.Resources.connStr;
            // string sql = @"SELECT * FROM Auth WHERE login = '" + user.Text +
            //"' AND password = '" + password.Text + "'";
            // SqlConnection conn = new SqlConnection(connStr);
            // conn.Open();
            // SqlDataReader reader;
            // SqlCommand command = new SqlCommand(sql, conn);
            // reader = command.ExecuteReader();
            // if (reader.HasRows)
            // {
            //     while (reader.Read())
            //     {
            //        int type = (int)reader["type"];
            //         MessageBox.Show("Такой пользователь найден, его роль = " + type.ToString(), "Успешно");

            //         Form1 form1 = new Form1();
            //         form1.Show();
            //         this.Hide();
            //     }
            // }
            // else
            // {
            //     MessageBox.Show("Такой пользователь не найден", "Ошибка");
            // }
            // conn.Close();
            this.Hide();
            Form1 form1 = new Form1();
            form1.UserLogin = true;
           // form1.Visible = true;
            form1.Show();

        }
    }
}
