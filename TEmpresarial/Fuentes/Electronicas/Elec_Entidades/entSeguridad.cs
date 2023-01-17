using System;

namespace Electronica_Entidades
{
    [Serializable]
    public class entSeguridad
    {
        public entSeguridad()
        {
            nId = -1;
            sApellido1 = "";
            sApellido2 = "";
            sNombre = "";
            sUsuario = "";
            sContrasenia = "";
            fAlta = DateTime.Now;
            fBaja = null;
            bEstado = false;
        }

        public int nId { get; set; }
        public string sApellido1 { get; set; }
        public string sApellido2 { get; set; }
        public string sNombre { get; set; }
        public string sUsuario { get; set; }
        public string sContrasenia { get; set; }
        public DateTime fAlta { get; set; }
        public Nullable<DateTime> fBaja { get; set; }
        public Boolean bEstado { get; set; }

        public string sNombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", sApellido1.Trim(), sApellido2.Trim(), sNombre.Trim());
            }
        }
    }
}
