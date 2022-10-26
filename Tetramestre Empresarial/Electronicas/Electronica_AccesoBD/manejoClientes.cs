using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ent = Electronica_Entidades;

namespace Electronica_AccesoBD
{
    public class manejoClientes
    {
        private SqlConnection sqlCon { get; set; }
        private SqlCommand sqlCom { get; set; }
        private SqlTransaction sqlTran { get; set; }
        private SqlDataAdapter sqlDat { get; set; }

        private string sConectBD { get { return ConfigurationManager.ConnectionStrings["datoBDElectronica"].ConnectionString.Trim(); } }

        public manejoClientes()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sConectBD);
            }
        }

        public List<ent.entSeguridad> ConsultaClientes(int? nIdCliente, string sApellido1, string sApellido2, string sNombre, string sRFC, string sCURP, Boolean? bolEstado)
        {
            List<ent.entSeguridad> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT IdCliente, Apellido1, Apellido2, Nombre, FechaAlta, CURP, RFC, Telefono, Correo, Direccion, FechaBaja, Estatus FROM elecCliente WHERE";
            try
            {
                result = new List<ent.entSeguridad>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                if (nIdCliente != null && nIdCliente > 0)
                {
                    sQuery = string.Format("{0} IdCliente = @nIdCliente AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@nIdCliente", SqlDbType.Int)).Value = nIdCliente;
                }
                if (sRFC != null && sRFC != "")
                {
                    sQuery = string.Format("{0} RFC LIKE '%' + @sRFC + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sRFC", SqlDbType.NVarChar, 13)).Value = sRFC;
                }
                if (sCURP != null && sCURP != "")
                {
                    sQuery = string.Format("{0} CURP LIKE '%' + @sCURP + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sCURP", SqlDbType.NVarChar, 20)).Value = sCURP;
                }
                if (sApellido1 != null && sApellido1 != "")
                {
                    sQuery = string.Format("{0} Apellido1 LIKE '%' + @sApellido1 + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sApellido1", SqlDbType.NVarChar, 150)).Value = sApellido1;
                }
                if (sApellido2 != null && sApellido2 != "")
                {
                    sQuery = string.Format("{0} Apellido2 LIKE '%' + @sApellido2 + '%' AND ", sQuery);
                    sqlCom.Parameters.Add(new SqlParameter("@sApellido2", SqlDbType.NVarChar, 150)).Value = sApellido2;
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
                sQuery = string.Format("{0} ORDER BY Estatus, Apellido1, Apellido2, Nombre", sQuery);

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
            catch (ApplicationException)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
            }
            catch (Exception)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
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

        public void AltaCliente(string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
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
            catch (ApplicationException)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
            }
            catch (Exception)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
            }
            finally
            {
                Finaliza();
            }
        }
        public void ActualizaCliente(int nIDUsuario, string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
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
            catch (ApplicationException)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
            }
            catch (Exception)
            {
                //ManejoLogErrores.txt_mensajeError(ex.ToString());
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
