using System;
using System.Collections.Generic;
using System.Configuration;
using ent = Electronica_Entidades;
using cBD = Elec_AccesoBD;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Electronica_ReglasNegocio
{
    public static class mUsuarios
    {
        public static ent.entSeguridad validaCredenciales(string sUsuario, string sContraseña)
        {
            ent.entSeguridad result = null;
            cBD.manejoSeguridad operacionUsuarios = null;
            try
            {
                operacionUsuarios = new cBD.manejoSeguridad();

                result = operacionUsuarios.validaCredenciales(sUsuario, sContraseña);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al validar los registros.", ex);
            }
            finally
            {
                operacionUsuarios.Finaliza();
            }
            return result;
        }

        public static List<ent.entSeguridad> consultaUsuarios(int? nIdUsuario, string sUsuario, string sApellido1, string sApellido2, string sNombre, Boolean? bolEstado)
        {
            List<ent.entSeguridad> result = null;
            cBD.manejoSeguridad operacionUsuarios = null;
            try
            {
                operacionUsuarios = new cBD.manejoSeguridad();
                
                result = operacionUsuarios.ConsultaUsuarios(nIdUsuario, sUsuario, sApellido1, sApellido2, sNombre, bolEstado);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al consultar los datos.", ex);
            }
            finally
            {
                operacionUsuarios.Finaliza();
            }
            return result;
        }

        public static void AltaUsuario(string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
        {
            cBD.manejoSeguridad operacionUsuarios = null;
            try
            {
                operacionUsuarios = new cBD.manejoSeguridad();

                operacionUsuarios.AltaUsuario(sApellido1, sApellido2, sNombre, sUsuario, sContraseña, bolEstado);
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
        public static void ActualizaUsuario(int nIDUsuario, string sApellido1, string sApellido2, string sNombre, string sUsuario, string sContraseña, Boolean bolEstado)
        {
            cBD.manejoSeguridad operacionUsuarios = null;
            try
            {
                operacionUsuarios = new cBD.manejoSeguridad();

                operacionUsuarios.ActualizaUsuario(nIDUsuario, sApellido1, sApellido2, sNombre, sUsuario, sContraseña, bolEstado);
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                mEx.Logs.MenejoLog.mensajeError(ex.Message);
                throw new ApplicationException("Error al actulizar el registro.", ex);
            }
            finally
            {
                operacionUsuarios.Finaliza();
            }
        }
    }
}
