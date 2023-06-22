using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auth_sql
{
    
    public partial class Form1 : Form
    {
        public bool UserLogin=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
    
            Console.WriteLine(UserLogin);
            if (UserLogin !=true)
            {
            this.Visible = false;
                Login sf = new Login();
                sf.ShowDialog();
                return;
            }
        }
    }
}
