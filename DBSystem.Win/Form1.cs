using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSystem.Core.Domain;
using DBSystem.Services;

namespace DBSystem.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var service = new ProductoService();

            productoBindingSource.DataSource = service.GetAllProductos(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new ProductoService();
            productoBindingSource.DataSource = service.GetAllProductos(textBox1.Text);
        }
    }
}
