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
    public class UsuarioImpl : IUsuario
    {
        string query;

        public MUsuario user;
        public UsuarioImpl u;
        
        public UsuarioImpl()
        {

        }
        public UsuarioImpl(MUsuario user)
        {
            this.user = user;
        }
        
        public void UpdatePassword(string passw)
        {
            UpdatPassword(passw);
        }
        public DataTable BuscarUsuario(string texto)
        {
            return buscaUsuario(texto);
        }
        public DataTable ci_like(string CI)
        {
            return cilk(CI);
        }
        public DataTable cilk(string CI)
        {
            DataTable res = new DataTable();
            string query = @"SELECT idUsuario,ci  FROM usuario
                WHERE  ci=md5(@ci) AND estado=1";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@ci", CI);
                res = DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;

        }
        public DataTable buscaUsuario(string texto)
        {
            DataTable res = new DataTable();
            string query = @"SELECT idUsuario, concat(nombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre Completo', ci as 'Ci', email as 'Email', rol as 'Rol'
                            FROM usuario
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
        public void UpdatPassword(string passw)
        {
            string query = @"UPDATE usuario SET ci=md5(@ci)
                            WHERE idUsuario=@id";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);

                cmd.Parameters.AddWithValue("@ci", passw);
                cmd.Parameters.AddWithValue("@id",user.IdUsuario);
                DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Delete(MUsuario b)
        {
            query = @"UPDATE usuario SET estado=0,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idUsuario=@idUsuario";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@idUsuario", b.IdUsuario);

                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public MUsuario Get(int id)
        {
            MUsuario res = null;

            string query = @" SELECT idUsuario,nombre,primerApellido,segundoApellido,ci,email,rol,estado,fechaActualizacion
                            FROM usuario
                            WHERE idUsuario=@id";

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = DBImplementation.ExecuteDataReaderCommand(cmd);

                while (dr.Read())
                {
                    res = new MUsuario(int.Parse(dr[0].ToString()),dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), byte.Parse(dr[7].ToString()), DateTime.Parse(dr[8].ToString()));
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

        public int Insert(MUsuario b)
        {
            query = @"INSERT INTO usuario ( nombre, primerApellido,segundoApellido, ci,email,rol,fechaActualizacion) 
                    values( @nombre, @primerApellido,@segundoApellido, md5(ci), @email, @rol, CURRENT_TIMESTAMP)";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", b.PrimerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", b.SegundoApellido);
                cmd.Parameters.AddWithValue("@ci", b.Ci);
                cmd.Parameters.AddWithValue("@email", b.Email);
                cmd.Parameters.AddWithValue("@rol", b.Rol);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable Login(string nombreUsuario, string password)
        {
            DataTable res = new DataTable();
            string query = @"SELECT idUsuario,primerApellido,rol,ci  FROM usuario
                WHERE primerApellido=@primerApellido AND ci=md5(@ci) AND estado=1";
            MySqlCommand cmd;
            try
            {
                cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@primerApellido", nombreUsuario);
                cmd.Parameters.AddWithValue("@ci", password);
                res = DBImplementation.ExecuteDataTableComand(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;

        }

        public DataTable Login1(string nombreUsuario, string password)
        {
            return Login(nombreUsuario, password);
        }

        public DataTable Select()
        {
            query = "SELECT * FROM vwusuario ORDER BY 2";
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

        public int Update(MUsuario b)
        {
            query = @"UPDATE usuario SET  nombre=@nombre, primerApellido=@primerApellido,segundoApellido=@segundoApellido, email=@email,rol=@rol,fechaActualizacion=CURRENT_TIMESTAMP 
                    WHERE idUsuario=@idUsuario";
            try
            {
                MySqlCommand cmd = DBImplementation.CreateBasicCommando(query);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@primerApellido", b.PrimerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", b.SegundoApellido);
                cmd.Parameters.AddWithValue("@email", b.Email);
                cmd.Parameters.AddWithValue("@rol", b.Rol);
                cmd.Parameters.AddWithValue("@idUsuario", b.IdUsuario);
                return DBImplementation.ExecuteBasicComand(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
