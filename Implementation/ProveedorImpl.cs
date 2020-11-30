using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Interfaces;
using System.Data;
using MySql.Data.MySqlClient;

namespace Implementation
{
    public class ProveedorImpl:IProveedor
    {
        string query;
        public DataTable BuscarProveedorN(string texto)
        {
            return BuscarProveedor(texto);
        }
        public DataTable BuscarProveedor(string texto)
        {
            DataTable res = new DataTable();
            string query = @"SELECT idProveedor, concat(nombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre Completo', direccion as 'Direccion', telefono as 'Telefono', fechaActualizacion as 'Registrado el:'
                            FROM proveedor
                            WHERE nombre  LIKE @texto and estado=1";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                res = DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return res;
        }
        public MProveedor Get(int id)
        {
            MProveedor res = null;

            string query = @" SELECT idProveedor,nombre,primerApellido,segundoApellido,direccion,telefono,estado,fechaActualizacion
                            FROM proveedor
                            WHERE idProveedor=@id";

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    //idProveedor,nombre,primerApellido,segundoApellido,direccion,telefono,estado,fechaActualizacion
                    
                    res = new MProveedor(int.Parse(dr[0].ToString()),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),int.Parse(dr[5].ToString()),byte.Parse(dr[6].ToString()),DateTime.Parse(dr[7].ToString()));
                }

            }
            catch (Exception ex)
            {


                throw ex;
            }
            finally
            {
                dr.Close();
                cmd.Connection.Close();
            }

            return res;
        }

        public int Delete(MProveedor b)
        {
            query = @"UPDATE proveedor SET estado=0,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idProveedor=@idProveedor";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@idProveedor", b.IdProveedor);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Insert(MProveedor b)
        {
            query = "insert into proveedor (nombre,primerApellido, segundoApellido, direccion, telefono) values (@nombre,@primerApellido, @segundoApellido, @direccion, @telefono)";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", b.PrimerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", b.SegundoApellido);
                cmd.Parameters.AddWithValue("@direccion", b.Direccion);
                cmd.Parameters.AddWithValue("@telefono", b.Telefono);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            query = "SELECT * FROM vwproveedor ORDER BY 2";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                return DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Update(MProveedor b)
        {
            query = @"UPDATE proveedor SET nombre=@nombre,primerApellido=@primerApellido,segundoApellido=@segundoApellido,direccion=@direccion,telefono=@telefono,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idProveedor=@idProveedor";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", b.PrimerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", b.SegundoApellido);
                cmd.Parameters.AddWithValue("@direccion", b.Direccion);
                cmd.Parameters.AddWithValue("@telefono", b.Telefono);
                cmd.Parameters.AddWithValue("@idProveedor", b.IdProveedor);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
