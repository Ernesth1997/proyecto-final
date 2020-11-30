using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public static  class Sesion
    {
        public static int idSesion;
        public static string usuarioSesion;
        public static string rolSesion;      
        public static string passwordSesion;
        //public static string ci;



        public static string VerInfo()
        {
            return "usario:" + usuarioSesion + "-Rol:" + rolSesion;
        }
    }
}
