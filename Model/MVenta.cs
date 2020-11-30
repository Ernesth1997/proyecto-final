using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MVenta
    {
        public int idVenta { get; set; }
        public decimal totalPago { get; set; }
        public decimal descuento { get; set; }
        public byte estado { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public MVenta()
        {

        }
        public MVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }
        public MVenta(int idVenta, decimal totalPago, decimal descuento, byte estado, DateTime fechaActualizacion, int idUsuario, int idCliente)
        {
            this.idVenta = idVenta;
            this.totalPago = totalPago;
            this.descuento = descuento;
            this.estado = estado;
            this.fechaActualizacion = fechaActualizacion;
            this.idUsuario = idUsuario;
            this.idCliente = idCliente;
        }
        public MVenta(decimal totalPago, decimal descuento, int idUsuario, int idCliente)
        {
            this.totalPago = totalPago;
            this.descuento = descuento;
            this.idUsuario = idUsuario;
            this.idCliente = idCliente;
        }
    }
}
