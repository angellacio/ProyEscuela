using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace Electronica_Comunes.ManejoErrores.Logs
{
    public class manejoLog_txt
    {
        // ** TXT ** Log_ArchivoNombre               // Nombre del Archivo. Si no se coloca se mandara con el nombre LogAuditoria.log
        // ** TXT ** Log_ArchivoUbicacion            // Ubicacion del Archivo. Si no se coloca se mandara con la ruta "Aplicativo"\Logs\
        // ** TXT ** Log_EscribeAuditoria            // Muestra todos los movimientos del aplicativo. SI, NO
        // ** TXT ** Log_ArchivoTamanio               // Tamaño del Archivo se maneje en Megas. Si se coloca 0 se toman como 10 MB

        private Boolean bolAuditoria
        {
            get
            {
                string sTransac = ConfigurationManager.AppSettings["Log_EscribeAuditoria"].ToString().Trim().ToUpper();
                return sTransac == "SI";
            }
        }
        private string sArchivo
        {
            get
            {
                string sNombre = "", sUbicacion = "", result = "";

                sNombre = ConfigurationManager.AppSettings["Log_ArchivoNombre"].ToString().Trim();
                sUbicacion = ConfigurationManager.AppSettings["Log_ArchivoUbicacion"].ToString().Trim();

                if (sNombre == "") sNombre = @"LogAuditoria.log";
                if (sUbicacion == "") sUbicacion = string.Format("{0}{1}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"file:\", ""), @"\Logs\");

                if (!Directory.Exists(sUbicacion)) Directory.CreateDirectory(sUbicacion);

                result = string.Format("{0}{1}", sUbicacion, sNombre);

                return result;
            }
        }
        private long nTamañoLog
        {
            get
            {
                long nResult = 0;

                if (!long.TryParse(ConfigurationManager.AppSettings["Log_ArchivoTamanio"].ToString().Trim(), out nResult))
                {
                    nResult = 10;
                }

                nResult = nResult * (1024 * 1024);

                return nResult;
            }
        }

        public void txt_mensajeStarFin(ManejoErrores.Logs.MenejoLog.AccionProceso aProceso)
        {
            string sMensaje = "";

            switch (aProceso)
            {
                case ManejoErrores.Logs.MenejoLog.AccionProceso.InicioServicio:
                    sMensaje = string.Format("****************************** {0:dd/MM/yyyy HH:mm:ss} * {1}", DateTime.Now, "Inicio Servicio.");
                    break;
                case ManejoErrores.Logs.MenejoLog.AccionProceso.FinalServicio:
                    sMensaje = string.Format("****************************** {0:dd/MM/yyyy HH:mm:ss} * {1}", DateTime.Now, "Fin Servicio.");
                    break;
                case ManejoErrores.Logs.MenejoLog.AccionProceso.InicioProceso:
                    sMensaje = string.Format("------------ {0:dd/MM/yyyy HH:mm:ss} - {1}", DateTime.Now, "Inicio proceso.");
                    break;
                case ManejoErrores.Logs.MenejoLog.AccionProceso.FinalProceso:
                    sMensaje = string.Format("------------ {0:dd/MM/yyyy HH:mm:ss} - {1}", DateTime.Now, "Fin proceso..");
                    break;
            }

            EscribeLog(sMensaje);
        }

        public void txt_mensajeAuditoria(string sMensaje)
        {
            if (bolAuditoria)
                EscribeLog(string.Format("+ {0:dd/MM/yyyy HH:mm:ss} + {1}", DateTime.Now, sMensaje));
        }

        public void txt_mensajeNormal(string sLog)
        {
            string sMensaje = "";

            sMensaje = string.Format("++ {0:dd/MM/yyyy HH:mm:ss} + {1}", DateTime.Now, sLog);

            EscribeLog(sMensaje);
        }

        public void txt_mensajeError(string sError)
        {
            string sMensaje = "";

            sMensaje = string.Format("{1:dd/MM/yyyy HH:mm:ss} ////////////////////////////// {0}{2}", Environment.NewLine, DateTime.Now, sError);

            EscribeLog(sMensaje);
        }

        private void EscribeLog(string sMensaje)
        {
            string sNomArchivoRespaldo = sArchivo;

            if (File.Exists(sArchivo))
            {
                FileInfo fiArchivoLog = new FileInfo(sArchivo);

                if (fiArchivoLog.Length >= nTamañoLog)
                {
                    sNomArchivoRespaldo = string.Format("{0}{1}{2}", sArchivo.Substring(0, sArchivo.Length - 4), "{0:yyyyMMddHHmmss}", sArchivo.Substring(sArchivo.Length - 4, 4));
                    sNomArchivoRespaldo = string.Format(sNomArchivoRespaldo, DateTime.Now);

                    File.Move(sArchivo, sNomArchivoRespaldo);
                }
            }

            StreamWriter WriteReportFile = File.AppendText(sArchivo);
            WriteReportFile.WriteLine(sMensaje);
            WriteReportFile.Close();
        }
    }
}
