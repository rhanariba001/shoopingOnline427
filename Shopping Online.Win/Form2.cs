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
    public partial class Form2 : Form
    {
        ReportedeVentasporProductosBL _reporteVentasporProductosBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentasporProductosBL = new ReportedeVentasporProductosBL();
        }
   
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();

        }
        private void RefrescarDatos()
        {
            var listadeVentasporProducto = _reporteVentasporProductosBL.ObtenerVentasporProductos();
            reportesVentasporProductosBindingSource.DataSource = listadeVentasporProducto;
            reportesVentasporProductosBindingSource.ResetBindings(false);

        }
    }
}
