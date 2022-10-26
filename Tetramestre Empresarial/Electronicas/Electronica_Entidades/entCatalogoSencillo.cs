using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica_Entidades
{
    [Serializable]
    public class entCatalogoSencillo
    {
        public entCatalogoSencillo()
        {
            nID = 0;
            sID = "";
            sAcronimo = "";
            sDescripcion = "";
            bEstado = false;
        }

        public int nID { get; set; }
        public string sID { get; set; }
        public string sAcronimo { get; set; }
        public string sDescripcion { get; set; }
        public Boolean bEstado { get; set; }
    }
}
