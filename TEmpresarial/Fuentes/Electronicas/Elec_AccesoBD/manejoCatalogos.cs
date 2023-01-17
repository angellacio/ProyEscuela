using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ent = Electronica_Entidades;
using mEx = Electronica_Comunes.ManejoErrores;


namespace Electronica_AccesoBD
{
    public class manejoCatalogos
    {
        private SqlConnection sqlCon { get; set; }
        private SqlCommand sqlCom { get; set; }
        private SqlTransaction sqlTran { get; set; }
        private SqlDataAdapter sqlDat { get; set; }

        private string sConectBD { get { return ConfigurationManager.ConnectionStrings["datoBDElectronica"].ConnectionString.Trim(); } }

        public manejoCatalogos()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sConectBD);
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

        public List<ent.entCatalogoSencillo> ConsultaCatalogoCompleto(int nIdTabla)
        {
            List<ent.entCatalogoSencillo> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eD.IdTabla, eT.Descripcion 'Tabla', eD.IdDescripcion, eD.Descripcion, eD.Estatus FROM elecTabla eT INNER JOIN elecDescripcion eD ON eT.IdTabla = eD.IdTabla WHERE eT.Estatus = 1 AND eD.IdTabla = @nIdTabla";
            try
            {
                result = new List<ent.entCatalogoSencillo>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nIdTabla", SqlDbType.Int)).Value = nIdTabla;

                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    result.Add(new ent.entCatalogoSencillo(sqlDR.GetInt32(sqlDR.GetOrdinal("IdDescripcion")), sqlDR.GetInt32(sqlDR.GetOrdinal("IdTabla")).ToString(), sqlDR.GetString(sqlDR.GetOrdinal("Tabla")), sqlDR.GetString(sqlDR.GetOrdinal("Descripcion")), sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"))));
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
                throw new ApplicationException("Error al consultar los catalogos.", ex);
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
        public List<ent.entCatalogoSencillo> ConsultaCatalogo(int nIdTabla)
        {
            List<ent.entCatalogoSencillo> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eD.IdTabla, eT.Descripcion 'Tabla', eD.IdDescripcion, eD.Descripcion, eD.Estatus FROM elecTabla eT INNER JOIN elecDescripcion eD ON eT.IdTabla = eD.IdTabla WHERE eT.Estatus = 1 AND eD.Estatus = 1 AND eD.IdTabla = @nIdTabla";
            try
            {
                result = new List<ent.entCatalogoSencillo>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nIdTabla", SqlDbType.Int)).Value = nIdTabla;

                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    result.Add(new ent.entCatalogoSencillo(sqlDR.GetInt32(sqlDR.GetOrdinal("IdDescripcion")), sqlDR.GetInt32(sqlDR.GetOrdinal("IdTabla")).ToString(), sqlDR.GetString(sqlDR.GetOrdinal("Tabla")), sqlDR.GetString(sqlDR.GetOrdinal("Descripcion")), sqlDR.GetBoolean(sqlDR.GetOrdinal("Estatus"))));
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
                throw new ApplicationException("Error al consultar los catalogos.", ex);
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
        public List<ent.entCatalogoSencillo> ConsultaTablas()
        {
            List<ent.entCatalogoSencillo> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eT.IdTabla, eT.Descripcion FROM elecTabla eT WHERE eT.Estatus = 1";
            try
            {
                result = new List<ent.entCatalogoSencillo>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();
                
                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    result.Add(new ent.entCatalogoSencillo(sqlDR.GetInt32(sqlDR.GetOrdinal("IdTabla")), "", "", sqlDR.GetString(sqlDR.GetOrdinal("Descripcion")), true));
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
                throw new ApplicationException("Error al consultar los catalogos.", ex);
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

        public void AltaCatalogo(int nIdTabla, string sDescripcion, Boolean bolEstado)
        {
            string sQuery = "INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(@nIdTabla, @sDescripcion, @bEstado)";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@nIdTabla", SqlDbType.Int)).Value = nIdTabla;
                sqlCom.Parameters.Add(new SqlParameter("@sDescripcion", SqlDbType.NVarChar)).Value = sDescripcion;
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

        public void ActualizaCatalogo(int nIdDescripcion, int nIdTabla, string sDescripcion, Boolean bolEstado)
        {
            string sQuery = "UPDATE elecDescripcion SET Descripcion = @sDescripcion, Estatus = @bEstado WHERE IdDescripcion = @nIdDescripcion";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.CommandText = sQuery;

                sqlCom.Parameters.Add(new SqlParameter("@nIdDescripcion", SqlDbType.Int)).Value = nIdDescripcion;
                sqlCom.Parameters.Add(new SqlParameter("@sDescripcion", SqlDbType.NVarChar)).Value = sDescripcion;
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
    }
}
