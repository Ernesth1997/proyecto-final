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
    public class CategoriaImpl : ICategoria
    {
        CategoriaImpl dal=null;
        string query;
        public int Delete(MCategoria b)
        {
            query = @"UPDATE categoria SET estado=0,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idCategoria=@idCategoria";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@idCategoria", b.IdCategoria);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public MCategoria Get(int id)
        {
            MCategoria res = null;

            string query = @" SELECT idCategoria,nombre,descripcion,estado,fechaActualizacion
                            FROM categoria
                            WHERE idCategoria=@id";

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res = new MCategoria(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), byte.Parse(dr[3].ToString()), DateTime.Parse(dr[4].ToString()));
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

        public int Insert(MCategoria b)
        {
            query = "INSERT INTO categoria (nombre,descripcion)VALUES (@nombre,@descripcion)";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", b.Descripcion);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            query = "SELECT * FROM vwcategoria ORDER BY 2";
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
        public DataTable SelectIDNames()
        {

            DataTable res = new DataTable();
            string query = @"SELECT idCategoria,nombre FROM categoria
                          WHERE estado=1";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                return DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable SelectIDName()
        {
            dal = new CategoriaImpl();
            return dal.SelectIDNames();
        }
        public int Update(MCategoria b)
        {
            query = @"UPDATE categoria SET nombre=@nombre,descripcion=@descripcion,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idCategoria=@idCategoria";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", b.Descripcion);
                cmd.Parameters.AddWithValue("@idCategoria", b.IdCategoria);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
