using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public static  class Generica
    {
        public static int id;
        public static string dato1;
        public static string dato2;
        public static string dato3;
        public static string dato4;
        public static string dato5;
        public static string dato6;

        /// <summary>
        /// cliente
        /// </summary>
        public static int idClient;
        public static string nit;
        public static string razonSocial;

        /// <summary>
        /// Proveedor
        /// </summary>
        public static int idProveedor;
        public static string ProveNombre;
        public static string PrimerApellido;

        /// <summary>
        /// producto datos para realizar venta
        /// </summary>
        public static int idProduct;
        public static string nombreProduct;        
        public static decimal precioVent;
        public static int stock;


        /// <summary>
        /// producto datos para realizar compra
        /// </summary>
        public static int idProd;
        public static string nombreProducto;
        public static string stockProducto;
        public static decimal precioCompra;
        public static string nroLote;
        public static DateTime fechaCaducidad;
        public static string presentacion;
    }
}
