using Shopping_Online.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Online.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.ObtenerProductos();
            listaDeProductosBindingSource.DataSource = listadeproductos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
