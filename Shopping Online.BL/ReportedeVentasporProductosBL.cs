using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Online.BL
{
    public class ReportedeVentasporProductosBL
    {
        Contexto _contexto;
        public List<ReportesVentasporProductos> ListadeVentasporProducto { get; set; }

        public ReportedeVentasporProductosBL()
        {
            _contexto = new Contexto();
            ListadeVentasporProducto = new List<ReportesVentasporProductos>();

        }
        public List<ReportesVentasporProductos> ObtenerVentasporProductos()
        {
            ListadeVentasporProducto = _contexto.OrdenDetalle
                .Include("Producto")
                .Where(r => r.Orden.Activo)
                .GroupBy(r => r.Producto.Descripcion)
                .Select(r => new ReportesVentasporProductos()
                {
                    Producto = r.Key,
                    Cantidad = r.Sum(s => s.Cantidad),
                    Total = r.Sum(s => s.Total)

                }).ToList();
            return ListadeVentasporProducto;
        }

    }

}
