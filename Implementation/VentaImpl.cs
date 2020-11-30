using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Model;
using MySql.Data.MySqlClient;

namespace Implementation
{
    public class VentaImpl : IVentas
    {
        MCliente cliente;
        MProducto product;
        //List<detalleVenta> detalle=new List<detalleVenta>();
        public VentaImpl Vent { get; set; }
        public MVenta vents { get; set; }
        public List<detalleVenta> detalle { get; set; }
        public MProducto Product { get; set; }

        public VentaImpl(MVenta vents, List<detalleVenta> detalle)
        {
            this.vents = vents;
            this.detalle = detalle;
        }

        public VentaImpl()
        {
           Vent=new VentaImpl(vents, detalle);
        }

       
      public DataTable SelectAutoImcrementIdVenta()
        {
            DataTable res = new DataTable();
            string query = @"select AUTO_INCREMENT 
                       from information_schema.tables
                       Where table_schema = 'bdagencias'
                       and table_name = 'venta'";
            MySqlCommand  cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                res = DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return res;
        }


        public int GetAutoincrementIdVenta()
        {
            return DBImplementation.GetAutoIncrementTable("venta");
        }
        public DataTable Select()
        {
            throw new NotImplementedException();
        }

        public void Delete(MVenta a)
        {
            throw new NotImplementedException();
        }

        public void Update(MVenta a)
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            string queryVenta = @"INSERT INTO venta(totalPago,descuento,idUsuario,idCliente)
                                           VALUES (@totalPago,@descuento,@idUsuario,@idCliente)";

            string queryDetalleVenta = @"INSERT INTO detalleventa(precioVenta,cantidad,idProducto,idVenta)
                                                         VALUES (@precioVenta,@cantidad,@idProducto,@idVenta)";

            List<MySqlCommand> cmds = new List<MySqlCommand>();

            try
            {
                cmds = DBImplementation.CreateNBasicCommand(1 + detalle.Count);
                cmds[0].CommandText = queryVenta;
                cmds[0].Parameters.AddWithValue("@totalPago", vents.totalPago);
                cmds[0].Parameters.AddWithValue("@descuento", vents.descuento);
                cmds[0].Parameters.AddWithValue("@idUsuario", Sesion.idSesion);
                cmds[0].Parameters.AddWithValue("@idCliente", vents.idCliente);

                int id = GetAutoincrementIdVenta();

                for (int i = 1; i < cmds.Count; i++)
                {
                    cmds[i].CommandText = queryDetalleVenta;
                    cmds[i].Parameters.AddWithValue("@precioVenta", detalle[i-1].PrecioVenta);
                    cmds[i].Parameters.AddWithValue("@cantidad", detalle[i-1].Cantidad);
                    cmds[i].Parameters.AddWithValue("@idProducto", detalle[i-1].IdProducto);
                    cmds[i].Parameters.AddWithValue("@idVenta",id);
                }
                DBImplementation.ExecuteNBasicComandTran(cmds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
