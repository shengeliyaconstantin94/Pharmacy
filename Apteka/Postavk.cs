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
    public partial class Postavk : Form
    {
        public Postavk()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");

        private void postavkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void Postavk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Postavki' table. You can move, or remove it, as needed.
            this.postavkiTableAdapter.Fill(this.dBDataSet.Postavki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            float n = float.Parse(price_per_unitTextBox.Text);
            float k = float.Parse(quantityTextBox.Text);
            float summ = k * n;
            summTextBox.Text = summ.ToString();
            connection.Open();
            string sqlQuery = "Insert into Postavki (  naimenovanie, date_postevki , postavshik,quantity,price_per_unit , summ) Values( N'" + naimenovanieTextBox.Text + "',N'" + date_postevkiDateTimePicker.Text + "',N'" + postavshikTextBox.Text + "',N'" + float.Parse(quantityTextBox.Text) + "',N'" + float.Parse(price_per_unitTextBox.Text)+ "' ,N'" + float.Parse(summTextBox.Text) + "')";
            cmd = new SqlCommand(sqlQuery, connection);
           
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Данные о поставке успешно сохранены");
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
            postavkiDataGridView.DataSource = update;

            connection.Close();
        }
    }
}
