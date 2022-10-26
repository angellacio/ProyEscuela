﻿using System;
using System.Collections.Generic;

namespace Electronica_Entidades
{
    [Serializable]
    public class entClientes
    {
        public entClientes()
        {
            nId = 0;
            sApellido1 = "";
            sApellido2 = "";
            sNombre = "";
            sCURP = "";
            sRFC = "";
            sTelefono = "";
            sCorreo = "";
            sDireccion = "";
            bEstdo = false;
            lstAutorizados = new List<entClientes>();
        }

        public int nId { get; set; }
        public string sApellido1 { get; set; }
        public string sApellido2 { get; set; }
        public string sNombre { get; set; }
        public string sCURP { get; set; }
        public string sRFC { get; set; }
        public string sTelefono { get; set; }
        public string sCorreo { get; set; }
        public string sDireccion { get; set; }
        public Boolean bEstdo { get; set; }
        public List<entClientes> lstAutorizados { get; set; }

        public string sNombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", sApellido1.Trim(), sApellido2.Trim(), sNombre.Trim());
            }
        }
    }
}
