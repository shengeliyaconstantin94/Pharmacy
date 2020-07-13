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
using System.IO;

namespace Apteka
{
    public partial class Prod : Form
    {
        public Prod()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void Prod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dBDataSet.Product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comand = connection.CreateCommand();
            comand.CommandText = "select * from Product";
            comand.ExecuteNonQuery();
            DataTable update = new DataTable();
            SqlDataAdapter updateda = new SqlDataAdapter(comand);
            updateda.Fill(update);
            productDataGridView.DataSource = update;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQuery = "select description, img from Product where articul_id = '"+textBox2.Text+"'";
           
            SqlCommand cmd = new SqlCommand(sqlQuery,connection);
            SqlDataReader DataRead = cmd.ExecuteReader();
            DataRead.Read();

            if (DataRead.HasRows)
            {
                textBox1.Text = DataRead[0].ToString();
                byte[] img = (byte[])DataRead[1];

                if (img == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstreem = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(mstreem);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Данные не доступны");
                connection.Close();
            }
        }
    }
}
