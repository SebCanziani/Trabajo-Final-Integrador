using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_API
{
    public partial class Form1 : Form
    {

            private string Url = "https://fakestoreapi.com/";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Producto> list = Producto.GetAll(url);
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {

                dataGridView1.SelectedRows[0].Cells[0].Value=0;

                }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
