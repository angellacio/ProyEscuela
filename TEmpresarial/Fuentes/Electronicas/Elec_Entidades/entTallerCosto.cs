using System;

namespace Electronica_Entidades
{
    [Serializable]
    public class entTallerCosto
    {
        public entTallerCosto(int IdTabla, string Tabla, int IdTipoCosto, string TipoCosto, int IDCosto, Decimal PorCobrar, Decimal Cobrado, Decimal Neto, string Observaciones, enumTextos.AccionPantalla AccionP)
        {
            inicializaComponente(IdTabla, Tabla, IdTipoCosto, TipoCosto, IDCosto, PorCobrar, Cobrado, Neto, Observaciones, AccionP);
        }
        public entTallerCosto()
        {
            inicializaComponente(-1, "", -1, "", -1, 0 ,0, 0, "", enumTextos.AccionPantalla.Elimina);
        }
        private void inicializaComponente(int IdTabla, string Tabla, int IdTipoCosto, string TipoCosto, int IDCosto, Decimal PorCobrar, Decimal Cobrado, Decimal Neto, string Observaciones, enumTextos.AccionPantalla AccionP)
        {
            nIdTabla = IdTabla;
            sTabla = Tabla;
            nIdTipoCosto = IdTipoCosto;
            sTipoCosto = TipoCosto;
            nIDCosto = IDCosto;
            mPorCobrar = PorCobrar;
            mCobrado = Cobrado;
            mNeto = Neto;
            sObservaciones = Observaciones;
            accionPantalla = AccionP;
        }

        public int nIdTabla { get; set; }
        public string sTabla { get; set; }
        public int nIdTipoCosto { get; set; }
        public string sTipoCosto { get; set; }
        public int nIDCosto { get; set; }
        public Decimal mMonto { get { return mPorCobrar + mCobrado; } }
        public Decimal mPorCobrar { get; set; }
        public Decimal mCobrado { get; set; }
        public Decimal mNeto { get; set; }
        public string sObservaciones { get; set; }

        public enumTextos.AccionPantalla accionPantalla { get; set; }
    }
}
