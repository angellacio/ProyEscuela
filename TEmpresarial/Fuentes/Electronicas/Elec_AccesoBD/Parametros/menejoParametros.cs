using System;
using segTextEnum = Electronica_Entidades.EnumTextos.Seguridad.textEnumSeguridad;

namespace Elec_AccesoBD.Parametros
{
    [Serializable]
    public class menejoParametros
    {
        public void manejoParametros()
        {
            sNombreParam = "";
            tParam = segTextEnum.tipoParametro.texto;
            nLong = null;
            valueParam = null;
        }

        public string sNombreParam { get; set; }
        public segTextEnum.tipoParametro tParam { get; set; }
        public int? nLong { get; set; }
        public object valueParam { get; set; }


    }
}
