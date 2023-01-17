using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ent = Electronica_Entidades;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Electronica_AccesoBD
{
    public class manejoSeguridad
    {
        private SqlConnection sqlCon { get; set; }
        private SqlCommand sqlCom { get; set; }
        private SqlTransaction sqlTran { get; set; }
        private SqlDataAdapter sqlDat { get; set; }

        private string sConectBD { get { return ConfigurationManager.ConnectionStrings["datoBDElectronica"].ConnectionString.Trim(); } }

        public manejoSeguridad()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sConectBD);
            }
        }

        public ent.entSeguridad validaCredenciales(string sUsuario, string sContraseña)
        {
            ent.entSeguridad result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT IdUsuairo, Apellido1, Apellido2, Nombre, FechaAlta, Usuario, Contrasenia, FechaBaja, Estatus FROM elecUsuario WHERE Estatus = 1 AND Usuario = @sUsuario AND Contrasenia = @sContrasenia";
            try
            {
                result = new ent.entSeguridad();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@sUsuario", SqlDbType.NVarChar, 8)).Value = sUsuario;
                sqlCom.Parameters.Add(new SqlParameter("@sContrasenia", SqlDbType.NVarChar, 8)).Value = sContraseña;
                
                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();
                while (sqlDR.Read())
                {
                    if (sqlDR["IdUsuairo"] != DBNull.Value) result.nId = sqlDR.GetInt32(sqlDR.GetOrdinal("IdUsuairo"));
                    if (sqlDR["Apellido1"] != DBNull.Value) result.sApellido1 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido1"));
                    if (sqlDR["Apellido2"] != DBNull.Value) result.sApellido2 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido2"));
                    if (sqlDR["Nombre"] != DBNull.Value) result.sNombre = sqlDR.GetString(sqlDR.GetOrdinal("Nombre"));
                    if (sqlDR["Usuario"] != DBNull.Value) result.sUsuario = sqlDR.GetString(sqlDR.GetOrdinal("Usuario"));
                    if (sqlDR["Contrasenia"] != DBNull.Value) result.sContrasenia = sqlDR.GetString(sqlDR.GetOrdinal("Contrasenia"));
                    if (sqlDR["FechaAlta"] != DBNull.Value) result.fAlta = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaAlta"));
                    if (sqlDR["FechaBaja"] != DBNull.Value) result.fBaja = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaBaja"));
                    if (sqlDR["Estatus"] != DBNull.Value) result.bEstado = sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"));
                }

                if (result.nId == -1) throw new ApplicationException("Usuario o Contraseña incorrectos, favor de validar.");
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error en la autentificación.", ex);
            }
            finally
            {
                if (sqlDR != null)
                {
                    sqlDR.Close();
                    sqlDR.Dispose();
                }
                Finaliza();
            }
            return result;
        }

        public List<ent.entSeguridad> ConsultaUsuarios(int? nIdUsuario, string sUsuario, string sApellido1, string sApellido2, string sNombre, Boolean? bolEstado)
        {
            List<ent.entSeguridad> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT IdUsuairo, Apellido1, Apellido2, Nombre, FechaAlta, Usuario, Contrasenia, FechaBaja, Estatus FROM elecUsuario WHERE";
            try
            {
                result = new List<ent.entSeguridad>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                if (nIdUsuario != null && nIdUsuario > 0)
                {
                    sQuery = string.Format("{0} IdUsuairo = @nIdusuario AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@nIdusuario", SqlDbType.Int)).Value = nIdUsuario;
                }
                if (sUsuario != null && sUsuario != "")
                {
                    sQuery = string.Format("{0} Usuario LIKE '%' + @sUsuario + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sUsuario", SqlDbType.NVarChar, 8)).Value = sUsuario;
                }
                if (sApellido1 != null && sApellido1 != "")
                {
                    sQuery = string.Format("{0} Apellido1 LIKE '%' + @sApellido1 + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sApellido1", SqlDbType.NVarChar, 150)).Value = sUsuario;
                }
                if (sApellido2 != null && sApellido2 != "")
                {
                    sQuery = string.Format("{0} Apellido2 LIKE '%' + @sApellido2 + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sApellido2", SqlDbType.NVarChar, 150)).Value = sUsuario;
                }
                if (sNombre != null && sNombre != "")
                {
                    sQuery = string.Format("{0} Nombre LIKE '%' + @sNombre + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sNombre", SqlDbType.NVarChar, 250)).Value = sNombre;
                }
                if (bolEstado != null)
                {
                    sQuery = string.Format("{0} Estatus = @bEstado AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@bEstado", SqlDbType.Bit)).Value = bolEstado;
                }

                sQuery = sQuery.Substring(0, sQuery.Length - 5);
                sQuery = string.Format("{0} ORDER BY Estatus DESC, Apellido1, Apellido2, Nombre", sQuery);

                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    ent.entSeguridad entSeg = new ent.entSeguridad();

                    if (sqlDR["IdUsuairo"] != DBNull.Value) entSeg.nId = sqlDR.GetInt32(sqlDR.GetOrdinal("IdUsuairo"));
                    if (sqlDR["Apellido1"] != DBNull.Value) entSeg.sApellido1 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido1"));
                    if (sqlDR["Apellido2"] != DBNull.Value) entSeg.sApellido2 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido2"));
                    if (sqlDR["Nombre"] != DBNull.Value) entSeg.sNombre = sqlDR.GetString(sqlDR.GetOrdinal("Nombre"));
                    if (sqlDR["Usuario"] != DBNull.Value) entSeg.sUsuario = sqlDR.GetString(sqlDR.GetOrdinal("Usuario"));
                    if (sqlDR["Contrasenia"] != DBNull.Value) entSeg.sContrasenia = sqlDR.GetString(sqlDR.GetOrdinal("Contrasenia"));
                    if (sqlDR["FechaAlta"] != DBNull.Value) entSeg.fAlta = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaAlta"));
                    if (sqlDR["FechaBaja"] != DBNull.Value) entSeg.fBaja = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaBaja"));
                    if (sqlDR["Estatus"] != DBNull.Value) entSeg.bEstado = sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"));

                    result.Add(entSeg);
                }
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al consultar los usuarios.", ex);
            }
            finally
            {
                if (sqlDR != null)
                {
                    sqlDR.Close();
                    sqlDR.Dispose();
                }
                Finaliza();
            }
            return result;
        }

        public void AltaUsuario(string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
        {
            string sQuery = "INSERT INTO elecUsuario(Apellido1, Apellido2, Nombre, FechaAlta, Usuario, Contrasenia, Estatus) VALUES(@sApellido1, @sApellido2, @sNombre, GetDate(), @sUsuario, @sContrasenia, @bEstado)";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@sApellido1", SqlDbType.NVarChar, 150)).Value = sApellido1;
                sqlCom.Parameters.Add(new SqlParameter("@sApellido2", SqlDbType.NVarChar, 150)).Value = sApellido2;
                sqlCom.Parameters.Add(new SqlParameter("@sNombre", SqlDbType.NVarChar, 250)).Value = sNombre;
                sqlCom.Parameters.Add(new SqlParameter("@sUsuario", SqlDbType.NVarChar, 8)).Value = sUsuario;
                sqlCom.Parameters.Add(new SqlParameter("@sContrasenia", SqlDbType.NVarChar, 16)).Value = sContraseña;
                sqlCom.Parameters.Add(new SqlParameter("@bEstado", SqlDbType.Bit)).Value = bolEstado;

                sqlCom.CommandType = CommandType.Text;

                sqlCom.ExecuteNonQuery();
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al dar de alta.", ex);
            }
            finally
            {
                Finaliza();
            }
        }
        public void ActualizaUsuario(int nIDUsuario, string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
        {
            string sQuery = "UPDATE elecUsuario SET Apellido1=@sApellido1, Apellido2=@sApellido2, Nombre=@sNombre, Usuario=@sUsuario, Contrasenia=@sContrasenia, FechaBaja=CASE @bEstado WHEN 1 THEN null ELSE GetDate() END, Estatus=@bEstado WHERE IdUsuairo=@nIdUsuario";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@nIdUsuario", SqlDbType.Int)).Value = nIDUsuario;
                sqlCom.Parameters.Add(new SqlParameter("@sApellido1", SqlDbType.NVarChar, 150)).Value = sApellido1;
                sqlCom.Parameters.Add(new SqlParameter("@sApellido2", SqlDbType.NVarChar, 150)).Value = sApellido2;
                sqlCom.Parameters.Add(new SqlParameter("@sNombre", SqlDbType.NVarChar, 250)).Value = sNombre;
                sqlCom.Parameters.Add(new SqlParameter("@sUsuario", SqlDbType.NVarChar, 8)).Value = sUsuario;
                sqlCom.Parameters.Add(new SqlParameter("@sContrasenia", SqlDbType.NVarChar, 16)).Value = sContraseña;
                sqlCom.Parameters.Add(new SqlParameter("@bEstado", SqlDbType.Bit)).Value = bolEstado;

                sqlCom.CommandType = CommandType.Text;

                sqlCom.ExecuteNonQuery();
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al actualizar.", ex);
            }
            finally
            {
                Finaliza();
            }
        }

        public void Finaliza()
        {
            if (sqlTran != null)
            {
                sqlTran.Dispose();
            }
            if (sqlCom != null) sqlCom.Dispose();
            if (sqlCon != null)
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
        }
    }
}
