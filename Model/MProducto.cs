using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MProducto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int IdCategoria { get; set; }
        public MProducto()
        {
                
        }

        public MProducto(int idProducto, string nombreProducto,  decimal precioVenta, int stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioVenta = precioVenta;
            Stock = stock;
        }
        public MProducto(int idProducto, string nombreProducto, decimal precioCompra, decimal precioVenta, int stock, byte estado, DateTime fechaActualizacion)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="nombreProducto"></param>
        /// <param name="precioCompra"></param>
        /// <param name="precioVenta"></param>
        /// <param name="stock"></param>
        /// <param name="estado"></param>
        /// <param name="fechaActualizacion"></param>
        /// <param name="idCategoria"></param>
        public MProducto(int idProducto,string nombreProducto,decimal precioCompra,decimal precioVenta, int stock, byte estado, DateTime fechaActualizacion, int idCategoria)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
            IdCategoria = idCategoria;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="precioCompra"></param>
        /// <param name="precioVenta"></param>
        /// <param name="stock"></param>
        /// <param name="idCategoria"></param>
        public MProducto(string nombreProducto, decimal precioCompra, decimal precioVenta, int stock, int idCategoria)
        {
            NombreProducto = nombreProducto;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdCategoria = idCategoria;
        }
    }
}
