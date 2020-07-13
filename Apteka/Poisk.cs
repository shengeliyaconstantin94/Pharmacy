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
    public partial class Poisk : Form
    {
        public Poisk()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (comboBox1.Text == "НАИМЕНОВАНИЕ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product WHERE prod_name LIKE N'" + textBox1.Text + "%'", connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "ГРУППА")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product WHERE grupp LIKE N'" + textBox1.Text + "%'", connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "ОПИСАНИЕ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product WHERE description LIKE N'" + textBox1.Text + "%'", connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }

        }

        private void Poisk_Load(object sender, EventArgs e)
        {

        }
    }
}

