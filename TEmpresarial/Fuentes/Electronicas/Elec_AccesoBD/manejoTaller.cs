using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ent = Electronica_Entidades;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Elec_AccesoBD
{
    public class manejoTaller
    {
        private SqlConnection sqlCon { get; set; }
        private SqlCommand sqlCom { get; set; }
        private SqlTransaction sqlTran { get; set; }
        private SqlDataAdapter sqlDat { get; set; }

        private string sConectBD { get { return ConfigurationManager.ConnectionStrings["datoBDElectronica"].ConnectionString.Trim(); } }

        public manejoTaller()
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

        public List<ent.entTaller> EquipoConsulta(int? nidCliente, int? nIdTipoEquipo, string sMarca, string sNumSerie)
        {
            List<ent.entTaller> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eE.IdEquipo, eE.IdCliente, eC.Apellido1, eC.Apellido2, eC.Nombre, eC.CURP, eC.RFC, eC.Telefono, eC.Correo, eC.Direccion, eD.IdTabla, eE.IdTipoEquipo, eD.Descripcion 'TipoEquipo', eE.Marca, eE.NumeroSerie, eE.Observaciones, eE.FechaAlta, eE.FechaBaja, eE.IdEstatus, eD1.Descripcion 'Estatus', ISNULL(vCA.PorCobrar, 0) 'PorCobrar', ISNULL(vCA.Cobrados, 0) 'Cobrados', ISNULL(vCA.Neto, 0) 'Neto' FROM elecEquipo eE INNER JOIN elecCliente eC ON eE.IdCliente = eC.IdCliente INNER JOIN elecDescripcion eD ON eE.IdTipoEquipo = eD.IdDescripcion AND eD.IdTabla = 2 LEFT OUTER JOIN vw_CososAcomulado vCA ON eE.IdEquipo = vCA.IdEquipo INNER JOIN elecDescripcion eD1 ON eE.IdEstatus = eD1.IdDescripcion AND eD1.IdTabla = 1 WHERE";
            try
            {
                result = new List<ent.entTaller>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                if (nidCliente != null)
                {
                    sQuery = string.Format("{0} eE.IdCliente = {1} AND ", sQuery, "@nIdCliente");
                    sqlCom.Parameters.Add(new SqlParameter("@nIdCliente", SqlDbType.Int)).Value = nidCliente;
                }
                if (nIdTipoEquipo != null)
                {
                    sQuery = string.Format("{0} eE.IdTipoEquipo = {1} AND ", sQuery, "@nIdTipoEquipo");
                    sqlCom.Parameters.Add(new SqlParameter("@nIdTipoEquipo", SqlDbType.Int)).Value = nIdTipoEquipo;
                }
                if (sMarca != "")
                {
                    sQuery = string.Format("{0} eE.Marca = {1} AND ", sQuery, "@sMarca");
                    sqlCom.Parameters.Add(new SqlParameter("@sMarca", SqlDbType.NVarChar)).Value = sMarca;
                }
                if (sNumSerie != "")
                {
                    sQuery = string.Format("{0} eE.NumeroSerie = {1} AND ", sQuery, "@sNumSerie");
                    sqlCom.Parameters.Add(new SqlParameter("@sNumSerie", SqlDbType.NVarChar)).Value = sNumSerie;
                }

                sQuery = string.Format("{0} {1}", sQuery.Substring(0, sQuery.Length - 5), "GROUP BY eE.IdEquipo, eE.IdCliente, eC.Apellido1, eC.Apellido2, eC.Nombre, eC.FechaAlta, eC.CURP, eC.RFC, eC.Telefono, eC.Correo, eC.Direccion, eE.IdTipoEquipo, eD.IdTabla, eD.Descripcion, eE.Marca, eE.NumeroSerie, eE.Observaciones, eE.FechaAlta, eE.FechaBaja, eE.IdEstatus, eD1.Descripcion, vCA.PorCobrar, vCA.Cobrados, vCA.Neto");

                sqlCom.CommandText = sQuery;
                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    int nIdTaller = 0, nIdCliente = 0, nIdTipoEquipoC = 0, nIdEstatus = 0;
                    string sCli_Apellido1 = "", sCli_Apellido2 = "", sCli_Nombre = "", sCli_CURP = "", sCli_RFC = "", sCli_Telefono = "", sCli_Correo = "",
                           sCli_Direccion = "", sTipoEquipo = "", sMarcaC = "", sNumSerieC = "", sObservaciones = "", sEstatus = "";
                    Decimal dbMontoPorCobrar = 0, dbMontoCobrado = 0, dbMontoNeto = 0;

                    nIdTaller = sqlDR.GetInt32(sqlDR.GetOrdinal("IdEquipo"));
                    nIdCliente = sqlDR.GetInt32(sqlDR.GetOrdinal("IdCliente"));
                    sCli_Apellido1 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido1"));
                    sCli_Apellido2 = sqlDR.GetString(sqlDR.GetOrdinal("Apellido2"));
                    sCli_Nombre = sqlDR.GetString(sqlDR.GetOrdinal("Nombre"));
                    sCli_CURP = sqlDR.GetString(sqlDR.GetOrdinal("CURP"));
                    sCli_RFC = sqlDR.GetString(sqlDR.GetOrdinal("RFC"));
                    sCli_Telefono = sqlDR.GetString(sqlDR.GetOrdinal("Telefono"));
                    sCli_Correo = sqlDR.GetString(sqlDR.GetOrdinal("Correo"));
                    sCli_Direccion = sqlDR.GetString(sqlDR.GetOrdinal("Direccion"));
                    nIdTipoEquipoC = sqlDR.GetInt32(sqlDR.GetOrdinal("IdTipoEquipo"));
                    sTipoEquipo = sqlDR.GetString(sqlDR.GetOrdinal("TipoEquipo"));
                    sMarcaC = sqlDR.GetString(sqlDR.GetOrdinal("Marca"));
                    sNumSerieC = sqlDR.GetString(sqlDR.GetOrdinal("NumeroSerie"));
                    sObservaciones = sqlDR.GetString(sqlDR.GetOrdinal("Observaciones"));
                    nIdEstatus = sqlDR.GetInt32(sqlDR.GetOrdinal("IdEstatus"));
                    sEstatus = sqlDR.GetString(sqlDR.GetOrdinal("Estatus"));
                    dbMontoPorCobrar = sqlDR.GetDecimal(sqlDR.GetOrdinal("PorCobrar"));
                    dbMontoCobrado = sqlDR.GetDecimal(sqlDR.GetOrdinal("Cobrados"));
                    dbMontoNeto = sqlDR.GetDecimal(sqlDR.GetOrdinal("Neto"));

                    result.Add(new ent.entTaller(nIdTaller, nIdCliente, sCli_Apellido1, sCli_Apellido2, sCli_Nombre, sCli_CURP, sCli_RFC, sCli_Telefono, sCli_Correo, sCli_Direccion, nIdTipoEquipoC, sTipoEquipo, sMarcaC, sNumSerieC, sObservaciones, dbMontoPorCobrar, dbMontoCobrado, dbMontoNeto, nIdEstatus, sEstatus));
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
        public List<ent.entTallerCosto> EquipoCostoConsulta(int nidEquipoElectronico)
        {
            List<ent.entTallerCosto> result = null;
            SqlDataReader sqlDR = null;
            string sQuery = "SELECT eM.IdEquipoMonto, eM.IdEquipo, eD.IdTabla, eT.Descripcion 'Tabla', eM.IdTipoMonto, eD.Descripcion 'TipoMonto',  CASE eD.IdTabla WHEN 3 THEN eM.Monto ELSE 0 END 'PorCobrar', CASE eD.IdTabla WHEN 4 THEN eM.Monto ELSE 0 END 'Cobrados', eM.Observaciones FROM elecEquipoMontos eM INNER JOIN elecDescripcion eD ON eM.IdTipoMonto = eD.IdDescripcion INNER JOIN elecTabla eT ON eD.IdTabla = eT.IdTabla WHERE IdEquipo = @nEquipo ORDER BY IdTabla, TipoMonto";
            try
            {
                result = new List<ent.entTallerCosto>();

                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nEquipo", SqlDbType.Int)).Value = nidEquipoElectronico;

                sqlCom.CommandText = sQuery;

                sqlCom.CommandType = CommandType.Text;

                sqlDR = sqlCom.ExecuteReader();

                while (sqlDR.Read())
                {
                    result.Add(new ent.entTallerCosto(sqlDR.GetInt32(sqlDR.GetOrdinal("IdTabla")), sqlDR.GetString(sqlDR.GetOrdinal("Tabla")),
                        sqlDR.GetInt32(sqlDR.GetOrdinal("IdTipoMonto")), sqlDR.GetString(sqlDR.GetOrdinal("TipoMonto")),
                        sqlDR.GetInt32(sqlDR.GetOrdinal("IdEquipoMonto")), sqlDR.GetDecimal(sqlDR.GetOrdinal("PorCobrar")),
                        sqlDR.GetDecimal(sqlDR.GetOrdinal("Cobrados")), 0, sqlDR.GetString(sqlDR.GetOrdinal("Observaciones")), ent.enumTextos.AccionPantalla.Cambios));
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

        public int EquipoAlta(ent.entTaller itemAlta)
        {
            object idBD;
            int nResult = -1;
            string sQuery = "INSERT INTO elecEquipo(IdCliente, IdTipoEquipo, Marca, NumeroSerie, Observaciones, FechaAlta, FechaBaja, IdEstatus) VALUES(@IdCliente, @IdTipoEquipo, @Marca, @NumeroSerie, @Observaciones, GetDate(), null, @IdEstatus) SELECT SCOPE_IDENTITY()";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int)).Value = itemAlta.nIdCliente;
                sqlCom.Parameters.Add(new SqlParameter("@IdTipoEquipo", SqlDbType.Int)).Value = itemAlta.nIdTipoEquipo;
                sqlCom.Parameters.Add(new SqlParameter("@Marca", SqlDbType.NVarChar)).Value = itemAlta.sMarca;
                sqlCom.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.NVarChar)).Value = itemAlta.sNumSerie;
                sqlCom.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.NVarChar)).Value = itemAlta.sObservaciones;
                sqlCom.Parameters.Add(new SqlParameter("@IdEstatus", SqlDbType.Int)).Value = itemAlta.nEstatus;

                sqlCom.CommandText = sQuery;

                sqlCom.CommandType = CommandType.Text;

                idBD = sqlCom.ExecuteScalar();

                nResult = (int)int.Parse(idBD.ToString());
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al registrar el equipo electronico.", ex);
            }
            finally { }
            return nResult;
        }
        public void EquipoCostoAlta(int nEquipo, ent.entTallerCosto itemCosto)
        {
            string sQuery = "INSERT INTO elecEquipoMontos(IdEquipo, IdTipoMonto, Monto, Observaciones) VALUES(@nIdEquipo, @nIdTipoMonto, @dMonto, @sObservaciones)";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nIdEquipo", SqlDbType.Int)).Value = nEquipo;
                sqlCom.Parameters.Add(new SqlParameter("@nIdTipoMonto", SqlDbType.Int)).Value = itemCosto.nIdTipoCosto;
                sqlCom.Parameters.Add(new SqlParameter("@dMonto", SqlDbType.Decimal)).Value = itemCosto.mMonto;
                sqlCom.Parameters.Add(new SqlParameter("@sObservaciones", SqlDbType.NVarChar)).Value = itemCosto.sObservaciones;

                sqlCom.CommandText = sQuery;

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
                throw new ApplicationException("Error al registrar el equipo electronico.", ex);
            }
            finally { }
        }

        public void EquipoActualiza(ent.entTaller itemAlta)
        {
            string sQuery = "UPDATE elecEquipo SET IdCliente = @IdCliente, IdTipoEquipo = @IdTipoEquipo, Marca = @Marca, NumeroSerie = @NumeroSerie, Observaciones = @Observaciones, IdEstatus = @IdEstatus, FechaBaja = CASE @IdEstatus WHEN 2 THEN GetDate() ELSE NULL END WHERE IdEquipo = @IdEquipo";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@IdEquipo", SqlDbType.Int)).Value = itemAlta.nIdTaller;
                sqlCom.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int)).Value = itemAlta.nIdCliente;
                sqlCom.Parameters.Add(new SqlParameter("@IdTipoEquipo", SqlDbType.Int)).Value = itemAlta.nIdTipoEquipo;
                sqlCom.Parameters.Add(new SqlParameter("@Marca", SqlDbType.NVarChar)).Value = itemAlta.sMarca;
                sqlCom.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.NVarChar)).Value = itemAlta.sNumSerie;
                sqlCom.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.NVarChar)).Value = itemAlta.sObservaciones;
                sqlCom.Parameters.Add(new SqlParameter("@IdEstatus", SqlDbType.Int)).Value = itemAlta.nEstatus;

                sqlCom.CommandText = sQuery;

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
                throw new ApplicationException("Error al registrar el equipo electronico.", ex);
            }
            finally { }
        }
        public void EquipoCostoActualiza(int nEquipo, ent.entTallerCosto itemCosto)
        {
            string sQuery = "UPDATE elecEquipoMontos SET IdTipoMonto = @nIdTipoMonto, Monto = @dMonto, Observaciones = @sObservaciones WHERE IdEquipoMonto = @nIdEquipoMonto";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nIdEquipoMonto", SqlDbType.Int)).Value = itemCosto.nIDCosto;
                sqlCom.Parameters.Add(new SqlParameter("@nIdEquipo", SqlDbType.Int)).Value = nEquipo;
                sqlCom.Parameters.Add(new SqlParameter("@nIdTipoMonto", SqlDbType.Int)).Value = itemCosto.nIdTipoCosto;
                sqlCom.Parameters.Add(new SqlParameter("@dMonto", SqlDbType.Decimal)).Value = itemCosto.mMonto;
                sqlCom.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.NVarChar)).Value = itemCosto.sObservaciones;

                sqlCom.CommandText = sQuery;

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
                throw new ApplicationException("Error al registrar el equipo electronico.", ex);
            }
            finally
            {}
        }
        public void EquipoCostoElimina(int nIdEquipoMonto)
        {
            string sQuery = "DELETE FROM elecEquipoMontos WHERE IdEquipoMonto = @nIdEquipoMonto";
            try
            {
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                sqlCom = sqlCon.CreateCommand();

                sqlCom.Parameters.Add(new SqlParameter("@nIdEquipoMonto", SqlDbType.Int)).Value = nIdEquipoMonto;
                
                sqlCom.CommandText = sQuery;

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
                throw new ApplicationException("Error al registrar el equipo electronico.", ex);
            }
            finally
            {}
        }
    }
}
