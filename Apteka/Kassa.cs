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
    public partial class Kassa : Form
    {
        public Kassa()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");

        private void kassaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kassaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void Kassa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Kassa' table. You can move, or remove it, as needed.
            this.kassaTableAdapter.Fill(this.dBDataSet.Kassa);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comand = connection.CreateCommand();
            comand.CommandText = "select * from Kassa";
            comand.ExecuteNonQuery();
            DataTable update = new DataTable();
            SqlDataAdapter updateda = new SqlDataAdapter(comand);
            updateda.Fill(update);
            kassaDataGridView.DataSource = update;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = float.Parse(rozn_priceTextBox.Text);
            float k = float.Parse(quantityTextBox.Text);
            float summ = k * n;
            summTextBox.Text = summ.ToString();
            SqlCommand cmd = new SqlCommand();
            connection.Open();
            string sqlQuery = "Insert into Kassa (  oper_date, articul_id , prod_name,rozn_price,quantity , summ) Values( N'" + oper_dateDateTimePicker.Text + "',N'" + int.Parse(articul_idTextBox.Text) + "',N'" + prod_nameTextBox.Text + "',N'" + float.Parse(rozn_priceTextBox.Text) + "',N'" + float.Parse(quantityTextBox.Text) + "',N'" + float.Parse(summTextBox.Text) + "')";
            cmd = new SqlCommand(sqlQuery, connection);
            
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Данные о продукте успешно сохранены");
        }
    }
}
