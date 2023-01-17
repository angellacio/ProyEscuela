using System;
using System.Collections.Generic;
using ent = Electronica_Entidades;
using mBD = Electronica_AccesoBD;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Electronica_ReglasNegocio
{
    public static class mCatalogos
    {
        public static List<ent.entCatalogoSencillo> consultaAllCatalogoEstadosEquipo()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogoCompleto(1);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaAllCatalogoTipoEquipo()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogoCompleto(2);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaAllCatalogoPorCobrar()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogoCompleto(3);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaAllCatalogoCobrados()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogoCompleto(4);
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
                mClientes.Finaliza();
            }
            return result;
        }

        public static List<ent.entCatalogoSencillo> consultaCatalogoEstadosEquipo()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogo(1);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaCatalogoTipoEquipo()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogo(2);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaCatalogoPorCobrar()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogo(3);
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
                mClientes.Finaliza();
            }
            return result;
        }
        public static List<ent.entCatalogoSencillo> consultaCatalogoCobrados()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaCatalogo(4);
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
                mClientes.Finaliza();
            }
            return result;
        }

        public static List<ent.entCatalogoSencillo> consultaCatalogoTablas()
        {
            List<ent.entCatalogoSencillo> result = null;
            mBD.manejoCatalogos mClientes = null;
            try
            {
                mClientes = new mBD.manejoCatalogos();

                result = mClientes.ConsultaTablas();
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
                mClientes.Finaliza();
            }
            return result;
        }

        public static void AltaCatalogo(int nIdTabla, string sDescripcion, Boolean bolEstado)
        {
            mBD.manejoCatalogos operacionUsuarios = null;
            try
            {
                operacionUsuarios = new mBD.manejoCatalogos();

                operacionUsuarios.AltaCatalogo(nIdTabla, sDescripcion, bolEstado);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al dar de alta el registro.", ex);
            }
            finally
            {
                operacionUsuarios.Finaliza();
            }
        }
        public static void ActualizaCatalogo(int nIdDescripcion, int nIdTabla, string sDescripcion, Boolean bolEstado)
        {
            mBD.manejoCatalogos operacionUsuarios = null;
            try
            {
                operacionUsuarios = new mBD.manejoCatalogos();

                operacionUsuarios.ActualizaCatalogo(nIdDescripcion, nIdTabla, sDescripcion, bolEstado);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al dar de alta el registro.", ex);
            }
            finally
            {
                operacionUsuarios.Finaliza();
            }
        }
    }
}
