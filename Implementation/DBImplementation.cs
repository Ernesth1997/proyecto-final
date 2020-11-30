using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Implementation
{
    public class DBImplementation
    {
        static string cadenaConexion = "server=localhost;database=bdagencia;Uid=root;pwd=;Port=3306";
        static MySqlConnection conexion;
        public static MySqlCommand CreateBasicComand()
        {
            conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand res = new MySqlCommand();
            res.Connection = conexion;
            return res;
        }
        public static MySqlCommand CreateBasicCommando(string query)
        {
            conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand res = new MySqlCommand(query);
            res.Connection = conexion;
            return res;
        }

        public static string ExecuteScalarCommand(MySqlCommand cmd)
        {
            string res = null;
            try
            {
                cmd.Connection.Open();
                res = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }

        public static int GetAutoIncrementTable(string tabla)
        {
            int res = 0;
            string query = @"select AUTO_INCREMENT
                        from information_schema.tables 
                       Where table_schema = 'bdagencia'
                       and table_name = '" + tabla + "'";
            try
            {
                MySqlCommand cmd = CreateBasicCommando(query);

                res = int.Parse(ExecuteScalarCommand(cmd));
            }
            catch (Exception ex)
            {


                throw ex;
            }
            return res;
        }
        public static void ExecuteNBasicComandTran(List<MySqlCommand> cmds)
        {
            MySqlTransaction tran = null;
            try
            {
                cmds[0].Connection.Open();
                tran = cmds[0].Connection.BeginTransaction();
                foreach (MySqlCommand item in cmds)
                {
                    item.Transaction = tran;
                    item.ExecuteNonQuery();
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                cmds[0].Connection.Close();
            }
        }

        public static List<MySqlCommand> CreateNBasicCommand(int n)
        {
            List<MySqlCommand> res = new List<MySqlCommand>();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            for (int i = 0; i < n; i++)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                res.Add(cmd);
            }

            return res;
        }
        public static int ExecuteBasicComand(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static DataTable ExecuteDataTableComand(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public static MySqlDataReader ExecuteDataReaderCommand(MySqlCommand cmd)
        {
            MySqlDataReader res = null;
            try
            {
                cmd.Connection.Open();
                res = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return res;
        }
    } 
}
