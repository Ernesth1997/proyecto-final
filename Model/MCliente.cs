using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MCliente
    {
        public int IdCliente { get; set; }
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public MCliente()
        {

        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nit"></param>
        /// <param name="razonSocial"></param>
        /// <param name="estado"></param>
        /// <param name="fechaActualizacion"></param>
        public MCliente(int idCliente, string nit, string razonSocial, byte estado, DateTime fechaActualizacion)
        {
            IdCliente = idCliente;
            Nit = nit;
            RazonSocial = razonSocial;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
        }
        public MCliente(int idCliente, string nit, string razonSocial)
        {
            IdCliente = idCliente;
            Nit = nit;
            RazonSocial = razonSocial;
          
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nit"></param>
        /// <param name="razonSocial"></param>
        public MCliente(string nit, string razonSocial)
        {
            Nit = nit;
            RazonSocial = razonSocial;
        }
    }
}
