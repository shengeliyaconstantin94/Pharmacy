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

namespace Apteka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Login WHERE USERNAME = '" + textBox1.Text+"' AND PASSWORD = '"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Main mainwindow = new Main();
                this.Hide();
                mainwindow.Show();
            }
        }
    }
}
