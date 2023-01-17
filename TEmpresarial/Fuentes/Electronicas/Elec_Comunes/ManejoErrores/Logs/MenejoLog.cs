using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Electronica_Comunes.ManejoErrores.Logs
{
    public static class MenejoLog
    {
        // Log_TipoManejo 1 = Texto, 2 Windows Log

        // ** TXT ** Log_ArchivoNombre               // Nombre del Archivo. Si no se coloca se mandara con el nombre LogAuditoria.log
        // ** TXT ** Log_ArchivoUbicacion            // Ubicacion del Archivo. Si no se coloca se mandara con la ruta "Aplicativo"\Logs\
        // ** TXT ** Log_EscribeAuditoria            // Muestra todos los movimientos del aplicativo. SI, NO
        // ** TXT ** Log_ArchivoTamanio               // Tamaño del Archivo se maneje en Megas. Si se coloca 0 se toman como 10 MB

        public enum AccionProceso { InicioServicio, FinalServicio, InicioProceso, FinalProceso };

        private static int nTipoLog
        {
            get
            {
                int nResult = 0;
                int.TryParse(ConfigurationManager.AppSettings["Log_TipoManejo"].ToString().Trim(), out nResult);
                return nResult;
            }
        }
        private static manejoLog_txt LogTXT { get; set; }
        private static manejoLog_EW LogEW { get; set; }

        private static void InicializaComponente()
        {
            if (nTipoLog == 1)
            {
                if (LogTXT == null) LogTXT = new manejoLog_txt();
            }
            else
            {
                if (LogEW == null) LogEW = new manejoLog_EW("", 0);
            }
        }

        public static void mensajeStarFin(AccionProceso aProceso)
        {
            InicializaComponente();
            if (nTipoLog == 1)
            {
                LogTXT.txt_mensajeStarFin(aProceso);
            }
            else
            {
                LogEW.EW_mensajeStarFin(aProceso);
            }
        }
        public static void mensajeAuditoria(string sMensaje)
        {
            InicializaComponente();
            if (nTipoLog == 1)
            {
                LogTXT.txt_mensajeAuditoria(sMensaje);
            }
            else
            {
                LogEW.EW_mensajeAuditoria(sMensaje);
            }
        }
        public static void mensajeNormal(string sMensaje)
        {
            InicializaComponente();
            if (nTipoLog == 1)
            {
                LogTXT.txt_mensajeNormal(sMensaje);
            }
            else
            {
                LogEW.EW_mensajeNormal(sMensaje);
            }
        }
        public static void mensajeAlerta(string sMensaje)
        {
            InicializaComponente();
            if (nTipoLog == 1)
            {
                LogTXT.txt_mensajeNormal(sMensaje);
            }
            else
            {
                LogEW.EW_mensajeAlerta(sMensaje);
            }
        }
        public static void mensajeError(string sMensaje)
        {
            InicializaComponente();
            if (nTipoLog == 1)
            {
                LogTXT.txt_mensajeError(sMensaje);
            }
            else
            {
                LogEW.EW_mensajeError(sMensaje);
            }
        }
    }
}
