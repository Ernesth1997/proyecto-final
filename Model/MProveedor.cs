using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MProveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public MProveedor()
        {

        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="idProveedor"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="estado"></param>
        /// <param name="fechaActualizacion"></param>
        public MProveedor(int idProveedor,string nombre, string primerApellido, string segundoApellido,  string direccion, int telefono, byte estado, DateTime fechaActualizacion)
        {

            IdProveedor = idProveedor;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Direccion = direccion;
            Telefono = telefono;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        public MProveedor(string nombre, string primerApellido, string segundoApellido, string direccion, int telefono)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
