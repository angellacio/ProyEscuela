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
            apEstado = enumTextos.AccionPantalla.Alta;
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
        public enumTextos.AccionPantalla apEstado { get; set; }
        public List<entCliente> lstAutorizados { get; set; }

        public int nEstado {
            get
            {
                int nResult = 3;
                switch (apEstado)
                {
                    case enumTextos.AccionPantalla.Alta:
                        nResult = 1;
                        break;
                    case enumTextos.AccionPantalla.Cambios:
                        nResult = 2;
                        break;
                    default:
                        nResult = 3;
                        break;
                }
                return nResult;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        apEstado = enumTextos.AccionPantalla.Alta;
                        break;
                    case 2:
                        apEstado = enumTextos.AccionPantalla.Cambios;
                        break;
                    default:
                        apEstado = enumTextos.AccionPantalla.Elimina;
                        break;
                }
            } 
        }
        public string sNombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", sApellido1.Trim(), sApellido2.Trim(), sNombre.Trim());
            }
        }
    }
}
