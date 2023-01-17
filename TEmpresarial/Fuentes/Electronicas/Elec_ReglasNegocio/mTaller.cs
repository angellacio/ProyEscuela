using System;
using System.Collections.Generic;
using ent = Electronica_Entidades;
using mBD = Electronica_AccesoBD;
using mEx = Electronica_Comunes.ManejoErrores;

namespace Electronica_ReglasNegocio
{
    public static class mTaller
    {
        public static List<ent.entTaller> EquipoConsulta(string nidCliente, string nIdTipoEquipo, string sMarca, string sNumSerie)
        {
            List<ent.entTaller> result = null;
            mBD.manejoTaller mTaller = null;
            int? nIdC = null, nIdTE = null;
            try
            {
                mTaller = new mBD.manejoTaller();

                if (nidCliente != "") nIdC = int.Parse(nidCliente);
                if (nIdTipoEquipo != "-1") nIdTE = int.Parse(nIdTipoEquipo);

                result = mTaller.EquipoConsulta(nIdC, nIdTE, sMarca, sNumSerie);

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
                mTaller.Finaliza();
            }
            return result;
        }

        public static List<ent.entTallerCosto> EquipoCostoConsulta(int nIdEquipo)
        {
            List<ent.entTallerCosto> result = null;
            mBD.manejoTaller mTaller = null;
            try
            {
                mTaller = new mBD.manejoTaller();

                result = mTaller.EquipoCostoConsulta(nIdEquipo);
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
                mTaller.Finaliza();
            }
            return result;
        }

        public static void EquipoAlta(ent.entTaller itemAlta)
        {
            mBD.manejoTaller mTaller = null;
            int nIDEquipo = -1;
            try
            {
                mTaller = new mBD.manejoTaller();

                nIDEquipo = mTaller.EquipoAlta(itemAlta);

                itemAlta.nIdTaller = nIDEquipo;
                itemAlta.lstCostos.ForEach(itemC =>
                {
                    mTaller.EquipoCostoAlta(itemAlta.nIdTaller, itemC);
                    //mTaller.EquipoCostoActualiza(itemAlta.nIdTaller, itemC);
                });
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
                mTaller.Finaliza();
            }
        }

    }
}
