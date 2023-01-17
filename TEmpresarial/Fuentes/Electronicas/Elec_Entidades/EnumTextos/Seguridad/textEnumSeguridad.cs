using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica_Entidades.EnumTextos.Seguridad
{
    public class textEnumSeguridad
    {
        public enum tipoConsulta { sQuery, storeProcedure }
        public enum tipoParametro { textoChico, texto, textoLago, enteroCorto, entero, enteroLargo, desimalCorto, desimal, desimalLargo, fechaHora, siNo }
    }
}
