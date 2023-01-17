using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ent = Electronica_Entidades;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Elec_AccesoBD
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

        public List<ent.entCliente> ConsultaClientes(int? nIdCliente, string sApellido1, string sApellido2, string sNombre, string sRFC, string sCURP, Boolean? bolEstado)
        {
            List<ent.entCliente> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT IdCliente, Apellido1, Apellido2, Nombre, FechaAlta, CURP, RFC, Telefono, Correo, Direccion, FechaBaja, Estatus FROM elecCliente WHERE";
            try
            {
                result = new List<ent.entCliente>();

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
                sQuery = string.Format("{0} ORDER BY Estatus DESC, Apellido1, Apellido2, Nombre", sQuery);

                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    ent.entCliente entCli = new ent.entCliente();

                    if (sqlDR["IdCliente"] != DBNull.Value) entCli.nId = sqlDR.GetInt32(sqlDR.GetOrdinal("IdCliente"));
                    if (sqlDR["Apellido1"] != DBNull.Value) entCli.sApellido1 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido1"));
                    if (sqlDR["Apellido2"] != DBNull.Value) entCli.sApellido2 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido2"));
                    if (sqlDR["Nombre"] != DBNull.Value) entCli.sNombre = sqlDR.GetString(sqlDR.GetOrdinal("Nombre"));
                    if (sqlDR["FechaAlta"] != DBNull.Value) entCli.fAlta = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaAlta"));
                    if (sqlDR["CURP"] != DBNull.Value) entCli.sCURP = sqlDR.GetString(sqlDR.GetOrdinal("CURP"));
                    if (sqlDR["RFC"] != DBNull.Value) entCli.sRFC = sqlDR.GetString(sqlDR.GetOrdinal("RFC"));
                    if (sqlDR["Telefono"] != DBNull.Value) entCli.sTelefono = sqlDR.GetString(sqlDR.GetOrdinal("Telefono"));
                    if (sqlDR["Correo"] != DBNull.Value) entCli.sCorreo = sqlDR.GetString(sqlDR.GetOrdinal("Correo"));
                    if (sqlDR["Direccion"] != DBNull.Value) entCli.sDireccion = sqlDR.GetString(sqlDR.GetOrdinal("Direccion"));
                    if (sqlDR["FechaBaja"] != DBNull.Value) entCli.fBaja = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaBaja"));
                    if (sqlDR["Estatus"] != DBNull.Value) entCli.bEstdo = sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"));

                    result.Add(entCli);
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
                throw new ApplicationException("Error al consultar los clientes.", ex);
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
        public List<ent.entCliente> ConsultaEquiposPersonasRecojer(int nIdCliente)
        {
            List<ent.entCliente> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eR.IdCliente, eR.IdRecojer, eC.Apellido1, eC.Apellido2, eC.Nombre, eC.FechaAlta, eC.CURP, eC.RFC, eC.Telefono, eC.Correo, eC.Direccion, eC.FechaBaja, eC.Estatus FROM elecRecoger eR INNER JOIN elecCliente eC ON eR.IdRecojer = eC.IdCliente WHERE eR.IdCliente = @nIdCliente ORDER BY eR.IdCliente, eC.Estatus DESC, eC.Apellido1, eC.Apellido2, eC.Nombre";
            try
            {
                result = new List<ent.entCliente>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();
                
                sqlCom.Parameters.Add(new SqlParameter("@nIdCliente", SqlDbType.Int)).Value = nIdCliente;
                
                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    ent.entCliente entCli = new ent.entCliente();

                    if (sqlDR["IdCliente"] != DBNull.Value) entCli.nId = sqlDR.GetInt32(sqlDR.GetOrdinal("IdRecojer"));
                    if (sqlDR["Apellido1"] != DBNull.Value) entCli.sApellido1 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido1"));
                    if (sqlDR["Apellido2"] != DBNull.Value) entCli.sApellido2 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido2"));
                    if (sqlDR["Nombre"] != DBNull.Value) entCli.sNombre = sqlDR.GetString(sqlDR.GetOrdinal("Nombre"));
                    if (sqlDR["FechaAlta"] != DBNull.Value) entCli.fAlta = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaAlta"));
                    if (sqlDR["CURP"] != DBNull.Value) entCli.sCURP = sqlDR.GetString(sqlDR.GetOrdinal("CURP"));
                    if (sqlDR["RFC"] != DBNull.Value) entCli.sRFC = sqlDR.GetString(sqlDR.GetOrdinal("RFC"));
                    if (sqlDR["Telefono"] != DBNull.Value) entCli.sTelefono = sqlDR.GetString(sqlDR.GetOrdinal("Telefono"));
                    if (sqlDR["Correo"] != DBNull.Value) entCli.sCorreo = sqlDR.GetString(sqlDR.GetOrdinal("Correo"));
                    if (sqlDR["Direccion"] != DBNull.Value) entCli.sDireccion = sqlDR.GetString(sqlDR.GetOrdinal("Direccion"));
                    if (sqlDR["FechaBaja"] != DBNull.Value) entCli.fBaja = sqlDR.GetDateTime(sqlDR.GetOrdinal("FechaBaja"));
                    if (sqlDR["Estatus"] != DBNull.Value) entCli.bEstdo = sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"));

                    result.Add(entCli);
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
                throw new ApplicationException("Error al consultar los clientes.", ex);
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

        public void AltaCliente(string sApellido1, string sApellido2, string sNombre, string sCurp, string sRFC, string sTelefono, string sCorreo, string sDireccion, Boolean bolEstado)
        {
            string sQuery = "INSERT INTO elecCliente(Apellido1, Apellido2, Nombre, FechaAlta, CURP, RFC, Telefono, Correo, Direccion, Estatus) VALUES(@Apellido1, @Apellido2, @Nombre, GetDate(), @CURP, @RFC, @Telefono, @Correo, @Direccion, @Estatus)";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@Apellido1", SqlDbType.NVarChar, 150)).Value = sApellido1;
                sqlCom.Parameters.Add(new SqlParameter("@Apellido2", SqlDbType.NVarChar, 150)).Value = sApellido2;
                sqlCom.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 250)).Value = sNombre;
                sqlCom.Parameters.Add(new SqlParameter("@CURP", SqlDbType.NVarChar, 8)).Value = sCurp;
                sqlCom.Parameters.Add(new SqlParameter("@RFC", SqlDbType.NVarChar, 16)).Value = sRFC;
                sqlCom.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar, 16)).Value = sTelefono;
                sqlCom.Parameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar, 16)).Value = sCorreo;
                sqlCom.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar, 16)).Value = sDireccion;
                sqlCom.Parameters.Add(new SqlParameter("@Estatus", SqlDbType.Bit)).Value = bolEstado;

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
        public void ActualizaCliente(int nIDCliente, string sApellido1, string sApellido2, string sNombre, string sCurp, string sRFC, string sTelefono, string sCorreo, string sDireccion, Boolean bolEstado)
        {
            string sQuery = "UPDATE elecCliente SET Apellido1=@Apellido1, Apellido2=@Apellido2, Nombre=@Nombre, CURP=@CURP, RFC=@RFC, Telefono=@Telefono, Correo=@Correo, Direccion=@Direccion, FechaBaja=CASE @Estado WHEN 1 THEN null ELSE GetDate() END, Estatus = @Estado WHERE IdCliente = @IdCliente";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int)).Value = nIDCliente;
                sqlCom.Parameters.Add(new SqlParameter("@Apellido1", SqlDbType.NVarChar, 150)).Value = sApellido1;
                sqlCom.Parameters.Add(new SqlParameter("@Apellido2", SqlDbType.NVarChar, 150)).Value = sApellido2;
                sqlCom.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 250)).Value = sNombre;
                sqlCom.Parameters.Add(new SqlParameter("@CURP", SqlDbType.NVarChar, 8)).Value = sCurp;
                sqlCom.Parameters.Add(new SqlParameter("@RFC", SqlDbType.NVarChar, 16)).Value = sRFC;
                sqlCom.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar, 16)).Value = sTelefono;
                sqlCom.Parameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar, 16)).Value = sCorreo;
                sqlCom.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar, 16)).Value = sDireccion;
                sqlCom.Parameters.Add(new SqlParameter("@Estado", SqlDbType.Bit)).Value = bolEstado;

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
