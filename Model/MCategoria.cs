using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MCategoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public MCategoria()
        {

        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="idCategoria"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="estado"></param>
        /// <param name="fechaActualizacion"></param>
        public MCategoria(int idCategoria,string nombre, string descripcion, byte estado, DateTime fechaActualizacion)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        public MCategoria(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
