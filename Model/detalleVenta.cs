using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class detalleVenta
    {
        private decimal precioVenta;
        private int cantidad;
        private int idProducto;
        private int idVenta;
        
        public decimal PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int IdVenta
        {
            get
            {
                return idVenta;
            }

            set
            {
                idVenta = value;
            }
        }
        public detalleVenta(decimal precioVenta, int cantidad, int idProducto,int idVenta)
        {
            this.PrecioVenta = precioVenta;
            this.Cantidad = cantidad;
            this. IdProducto= idProducto;
            this.IdVenta=     idVenta;
        }
        public detalleVenta()
        {

        }
    }
}
