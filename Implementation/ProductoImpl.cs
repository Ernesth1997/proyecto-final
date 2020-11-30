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
    public class ProductoImpl: IProducto
    {
        string query;
        public int Delete(MProducto b)
        {
            query = @"UPDATE producto SET estado=0,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idProducto=@idProducto";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@idProducto", b.IdProducto);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public MProducto Get(int id)
        {
            MProducto res = null;

            string query = @" SELECT idProducto,nombreProducto,precioCompra,precioVenta,stock,estado,fechaActualizacion
                            FROM producto
                            WHERE idProducto=@id";

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res = new MProducto(int.Parse(dr[0].ToString()), dr[1].ToString(),decimal.Parse(dr[2].ToString()), decimal.Parse(dr[3].ToString()), int.Parse(dr[4].ToString()),byte.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString())/*, int.Parse(dr[7].ToString())*/);
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

        public int Insert(MProducto b)
        {
            query = "INSERT INTO producto (nombreProducto,precioCompra,precioVenta,stock,idCategoria) VALUES (@nombreProducto,@precioCompra,@precioVenta,@stock,@idCategoria)";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombreProducto", b.NombreProducto);
                cmd.Parameters.AddWithValue("@precioCompra", b.PrecioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", b.PrecioVenta);
                cmd.Parameters.AddWithValue("@stock", b.Stock);
                cmd.Parameters.AddWithValue("@idCategoria", b.IdCategoria);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            query = "select * from vwProducto order by 2";
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

        public int Update(MProducto b)
        {
            query = @"UPDATE producto SET nombreProducto=@nombreProducto,precioCompra=@precioCompra,precioVenta=@precioVenta,stock=@stock,idCategoria=@idCategoria,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idProducto=@idProducto";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombreProducto", b.NombreProducto);
                cmd.Parameters.AddWithValue("@precioCompra", b.PrecioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", b.PrecioVenta);
                cmd.Parameters.AddWithValue("@stock", b.Stock);
                cmd.Parameters.AddWithValue("@idCategoria", b.IdCategoria);
                cmd.Parameters.AddWithValue("@idProducto", b.IdProducto);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
