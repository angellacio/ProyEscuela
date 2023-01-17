using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace Electronica_Comunes.ManejoErrores.Logs
{
    public class manejoLog_EW
    {
        private string sLog { get { return ConfigurationManager.AppSettings["RegLog"].ToString().ToUpper().Trim(); } }
        private string sSource { get; set; }
        private int nEvento { get; set; }
        private Boolean bolAuditoria
        {
            get
            {
                string sTransac = ConfigurationManager.AppSettings["Log_EscribeAuditoria"].ToString().Trim().ToUpper();
                return sTransac == "SI";
            }
        }
        private EventLog escribeLog { get; set; }

        public manejoLog_EW(string nomSource, int numEvento)
        {
            sSource = nomSource;
            nEvento = numEvento;

            if (EventLog.SourceExists(sSource) == false)
            {
                EventSourceCreationData sCrear = new EventSourceCreationData(sSource, sLog);
                EventLog.CreateEventSource(sCrear);
            }
            escribeLog = new EventLog(sLog);
            escribeLog.Source = sSource;

            ((System.ComponentModel.ISupportInitialize)(escribeLog)).BeginInit();
        }

        public void EW_mensajeStarFin(ManejoErrores.Logs.MenejoLog.AccionProceso aProceso)
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

            if (bolAuditoria)
                EscribeMensaje(sMensaje, EventLogEntryType.SuccessAudit);
        }

        public void EW_mensajeAuditoria(string sMensaje)
        {
            if (bolAuditoria)
                EscribeMensaje(string.Format("+ {0:dd/MM/yyyy HH:mm:ss} + {1}", DateTime.Now, sMensaje), EventLogEntryType.SuccessAudit);
        }

        public void EW_mensajeNormal(string sLog)
        {
            string sMensaje = "";

            sMensaje = string.Format("++ {0:dd/MM/yyyy HH:mm:ss} + {1}", DateTime.Now, sLog);

            EscribeMensaje(sMensaje, EventLogEntryType.Information);
        }
        public void EW_mensajeAlerta(string sError)
        {
            string sMensaje = "";

            sMensaje = string.Format("{1:dd/MM/yyyy HH:mm:ss} ////////////////////////////// {0}{2}", Environment.NewLine, DateTime.Now, sError);

            EscribeMensaje(sMensaje, EventLogEntryType.Warning);
        }

        public void EW_mensajeError(string sError)
        {
            string sMensaje = "";

            sMensaje = string.Format("{1:dd/MM/yyyy HH:mm:ss} ////////////////////////////// {0}{2}", Environment.NewLine, DateTime.Now, sError);

            EscribeMensaje(sMensaje, EventLogEntryType.Error);
        }

        private void EscribeMensaje(string sMensaje, EventLogEntryType TypeLog)
        {
            //if (escribeLog == null) CreaComponentes();
            escribeLog.WriteEntry(sMensaje, TypeLog, nEvento);
        }
    }
}
