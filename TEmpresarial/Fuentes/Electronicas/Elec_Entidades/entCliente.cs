using System;
using System.Collections.Generic;

namespace Electronica_Entidades
{
    [Serializable]
    public class entCliente
    {
        public entCliente()
        {
            nId = 0;
            sApellido1 = "";
            sApellido2 = "";
            sNombre = "";
            fAlta = null;
            sCURP = "";
            sRFC = "";
            sTelefono = "";
            sCorreo = "";
            sDireccion = "";
            fBaja = null;
            bEstdo = false;
            lstAutorizados = new List<entCliente>();
        }

        public int nId { get; set; }
        public string sApellido1 { get; set; }
        public string sApellido2 { get; set; }
        public string sNombre { get; set; }
        public Nullable<DateTime> fAlta { get; set; }
        public string sCURP { get; set; }
        public string sRFC { get; set; }
        public string sTelefono { get; set; }
        public string sCorreo { get; set; }
        public string sDireccion { get; set; }
        public Nullable<DateTime> fBaja { get; set; }
        public Boolean bEstdo { get; set; }
        public List<entCliente> lstAutorizados { get; set; }

        public string sNombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", sApellido1.Trim(), sApellido2.Trim(), sNombre.Trim());
            }
        }
    }
}
