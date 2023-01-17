using System;
using System.Collections.Generic;
using ent = Electronica_Entidades;
using mBD = Elec_AccesoBD;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Electronica_ReglasNegocio
{
    public static class mCliente
    {
        public static List<ent.entCliente> ConsultaClientes(int? nIdCliente, string sApellido1, string sApellido2, string sNombre, string sRFC, string sCURP, Boolean? bolEstado)
        {
            List<ent.entCliente> result = null;
            mBD.manejoClientes mClientes = null;
            try
            {
                mClientes = new mBD.manejoClientes();

                result = mClientes.ConsultaClientes(nIdCliente, sApellido1, sApellido2, sNombre, sRFC, sCURP, bolEstado);

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

        public static List<ent.entCliente> ConsultaEquiposPersonasRecojer(int nIdCliente)
        {
            List<ent.entCliente> result = null;
            mBD.manejoClientes mClientes = null;
            try
            {
                mClientes = new mBD.manejoClientes();

                result = mClientes.ConsultaEquiposPersonasRecojer(nIdCliente);
            }
            catch (ApplicationException ex)
            {
                mEx.Logs.MenejoLog.mensajeAlerta(ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al consultar los equipos electronicos.", ex);
            }
            finally
            {
                mClientes.Finaliza();
            }
            return result;
        }

        public static void AltaCliente(string sApellido1, string sApellido2, string sNombre, string sCurp, string sRFC, string sTelefono, string sCorreo, string sDireccion, Boolean bolEstado)
        {
            mBD.manejoClientes mClientes = null;
            try
            {

                mClientes = new mBD.manejoClientes();

                mClientes.AltaCliente(sApellido1, sApellido2, sNombre, sCurp, sRFC, sTelefono, sCorreo, sDireccion, bolEstado);
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
                mClientes.Finaliza();
            }
        }
        public static void ActualizaCliente(int nIDCliente, string sApellido1, string sApellido2, string sNombre, string sCurp, string sRFC, string sTelefono, string sCorreo, string sDireccion, Boolean bolEstado)
        {
            mBD.manejoClientes mClientes = null;
            try
            {
                mClientes = new mBD.manejoClientes();

                mClientes.ActualizaCliente(nIDCliente, sApellido1, sApellido2, sNombre, sCurp, sRFC, sTelefono, sCorreo, sDireccion, bolEstado);
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
                mClientes.Finaliza();
            }
        }
    }
}
