using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class ProductoVenta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public decimal PreVenta { get; set; }
        public int CantProducto { get; set; }
        public decimal importe { get; set; }
        public decimal totalPago { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalDescuento { get; set; }
        public string Stock { get; set; }
        public int stockActual { get; set; }
    }
}
