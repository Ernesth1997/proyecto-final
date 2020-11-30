using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Ci { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        
        public MUsuario()
        {

        }
        //public MUsuario(string nombreUsuario)
        //{
        //    this.nombreUsuario = nombreUsuario;
        //}
        public MUsuario(string nombreUsuario, string password)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="ci"></param>
        /// <param name="email"></param>
        /// <param name="rol"></param>
        /// <param name="estado"></param>
        /// <param name="fechaActualizacion"></param>
        public MUsuario(int idUsuario, string nombre, string primerApellido,string segundoApellido, string ci, string email, string rol, byte estado, DateTime fechaActualizacion)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Ci = Ci;
            Email = email;
            Rol = rol;
            Estado = estado;
            FechaActualizacion = fechaActualizacion;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="rol"></param>
        public MUsuario( string nombre, string primerApellido, string segundoApellido, string ci, string email, string rol)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Ci = ci;
            Email = email;
            Rol = rol;
        }
        public MUsuario( string ci)
        {
       
            Ci = ci;
         
        }
    }
}
