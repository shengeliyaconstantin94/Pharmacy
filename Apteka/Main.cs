using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prod prodlist = new Prod();
            prodlist.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Postavk postavki = new Postavk();
            postavki.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poisk poisk = new Poisk();
            poisk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kassa kas = new Kassa();
            kas.Show();
        }
    }
}
