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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Аптека\Apteka\Apteka\DB.mdf;Integrated Security=True");
        string imglocation = "";
        SqlCommand cmd = new SqlCommand();



        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void EditForm_Load(object sender, EventArgs e)
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
            OpenFileDialog vievdialog = new OpenFileDialog();

            vievdialog.Filter = "png filles(*.png|*.png|jpg filles(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (vievdialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = vievdialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;

               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] img = null;
            FileStream Streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            img = brs.ReadBytes((int)Streem.Length);



            connection.Open();
            string sqlQuery = "Insert into Product (  prod_name, doz , zak_price,rozn_price,grupp , description, img) Values( N'" + prod_nameTextBox.Text + "',N'" + dozTextBox.Text + "',N'" + zak_priceTextBox.Text + "',N'" + rozn_priceTextBox.Text + "',N'" + gruppComboBox.Text + "',N'" + descriptionTextBox.Text + "' ,@images)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@images", img));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show( "Данные о продукте успешно сохранены");
        }
    }
}
