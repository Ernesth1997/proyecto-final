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
    public class ClienteImpl : ICliente
    {
        string query;
        public DataTable BuscarClienteN(string texto, string texto1)
        {
            return BuscarClienteNit(texto,texto1);
        }
        public DataTable BuscarClienteNit(string texto, string texto1)
        {
            DataTable res = new DataTable();
            string query = @"SELECT idCliente,nit AS 'Nit',razonSocial AS 'Razon Social',FechaActualizacion AS 'Fecha De Actualizacion' FROM cliente
                                WHERE nit  LIKE @texto or razonSocial LIKE @texto1 and estado=1";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                cmd.Parameters.AddWithValue("@texto1", "%" + texto1 + "%");
                res = DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return res;
        }
        public int Delete(MCliente b)
        {
            query = @"UPDATE cliente SET estado=0,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idCliente=@idCliente";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@idCliente", b.IdCliente);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public MCliente Get(int id)
        {
            MCliente res = null;

            string query = @" SELECT idCliente,nit,razonSocial,estado,fechaActualizacion
                            FROM cliente
                            WHERE idCliente=@id";

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res = new MCliente(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), byte.Parse(dr[3].ToString()), DateTime.Parse(dr[4].ToString()));
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

        public int Insert(MCliente b)
        {
            query = "INSERT INTO cliente (nit,razonSocial)VALUES (@nit,@razonSocial)";
            try
            {
                MySqlCommand cmd =DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nit",b.Nit);
                cmd.Parameters.AddWithValue("@razonSocial", b.RazonSocial);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            query = "SELECT * FROM vwcliente ORDER BY 2";
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

        public int Update(MCliente b)
        {
            query = @"UPDATE cliente SET nit=@nit,razonSocial=@razonSocial,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idCliente=@idCliente";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nit", b.Nit);
                cmd.Parameters.AddWithValue("@razonSocial", b.RazonSocial);
                cmd.Parameters.AddWithValue("@idCliente", b.IdCliente);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
