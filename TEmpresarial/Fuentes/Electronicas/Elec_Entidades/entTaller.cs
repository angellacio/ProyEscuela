using System;
using System.Collections.Generic;

namespace Electronica_Entidades
{
    [Serializable]
    public class entTaller
    {
        private decimal _dbMontoPorCobrar;
        private decimal _dbMontoCobrado;
        private decimal _dbMontoNeto;

        public entTaller(int IdTaller, int IdCliente, string Cli_Apellido1, string Cli_Apellido2, string Cli_Nombre, string Cli_CURP, string Cli_RFC, string Cli_Telefono, string Cli_Correo, string Cli_Direccion, int IdTipoEquipo, string TipoEquipo, string Marca, string NumSerie, string Observaciones, Decimal MontoPorCobrar, Decimal MontoCobrado, Decimal MontoNeto, int Estatus, string tEstatus, List<entTallerCosto> Costos, List<entCliente> PersonasRecoge)
        {
            inicializaComponente(IdTaller, IdCliente, Cli_Apellido1, Cli_Apellido2, Cli_Nombre, Cli_CURP, Cli_RFC, Cli_Telefono, Cli_Correo, Cli_Direccion, IdTipoEquipo, TipoEquipo, Marca, NumSerie, Observaciones, MontoPorCobrar, MontoCobrado, MontoNeto, Estatus, tEstatus, Costos, PersonasRecoge);
        }
        public entTaller(int IdTaller, int IdCliente, string Cli_Apellido1, string Cli_Apellido2, string Cli_Nombre, string Cli_CURP, string Cli_RFC, string Cli_Telefono, string Cli_Correo, string Cli_Direccion, int IdTipoEquipo, string TipoEquipo, string Marca, string NumSerie, string Observaciones, Decimal MontoPorCobrar, Decimal MontoCobrado, Decimal MontoNeto, int Estatus, string tEstatus)
        {
            inicializaComponente(IdTaller, IdCliente, Cli_Apellido1, Cli_Apellido2, Cli_Nombre, Cli_CURP, Cli_RFC, Cli_Telefono, Cli_Correo, Cli_Direccion, IdTipoEquipo, TipoEquipo, Marca, NumSerie, Observaciones, MontoPorCobrar, MontoCobrado, MontoNeto, Estatus, tEstatus, new List<entTallerCosto>(), new List<entCliente>());
        }
        public entTaller()
        {
            inicializaComponente(-1, -1, "", "", "", "", "", "", "", "", -1, "", "", "", "", 0, 0, 0, 0, "", new List<entTallerCosto>(), new List<entCliente>());
        }
        private void inicializaComponente(int IdTaller, int IdCliente, string Cli_Apellido1, string Cli_Apellido2, string Cli_Nombre, string Cli_CURP, string Cli_RFC, string Cli_Telefono, string Cli_Correo, string Cli_Direccion, int IdTipoEquipo, string TipoEquipo, string Marca, string NumSerie, string Observaciones, Decimal MontoPorCobrar, Decimal MontoCobrado, Decimal MontoNeto, int Estatus, string tEstatus, List<entTallerCosto> Costos, List<entCliente> PersonasRecoge)
        {
            nIdTaller = IdTaller;
            nIdCliente = IdCliente;
            sCli_Apellido1 = Cli_Apellido1;
            sCli_Apellido2 = Cli_Apellido2;
            sCli_Nombre = Cli_Nombre;
            sCli_CURP = Cli_CURP;
            sCli_RFC = Cli_RFC;
            sCli_Telefono = Cli_Telefono;
            sCli_Correo = Cli_Correo;
            sCli_Direccion = Cli_Direccion;
            nIdTipoEquipo = IdTipoEquipo;
            sTipoEquipo = TipoEquipo;
            sMarca = Marca;
            sNumSerie = NumSerie;
            sObservaciones = Observaciones;
            nEstatus = Estatus;
            sEstatus = tEstatus;
            _dbMontoPorCobrar = MontoPorCobrar;
            _dbMontoCobrado = MontoCobrado;
            _dbMontoNeto = MontoNeto;
            lstCostos = Costos;
            lstPersonasRecoge = PersonasRecoge;
        }

        public int nIdTaller { get; set; }
        public string sClienteC { get { return string.Format("{0} :: {1} {2} {3} :: {4}", nIdCliente, sCli_Apellido1, sCli_Apellido2, sCli_Nombre, sCli_RFC); } }
        public int nIdCliente { get; set; }
        public string sCli_Apellido1 { get; set; }
        public string sCli_Apellido2 { get; set; }
        public string sCli_Nombre { get; set; }
        public string sCli_CURP { get; set; }
        public string sCli_RFC { get; set; }
        public string sCli_Telefono { get; set; }
        public string sCli_Correo { get; set; }
        public string sCli_Direccion { get; set; }
        public string TipoEquipo { get { return string.Format("{0} :: {1}", nIdTipoEquipo, sTipoEquipo); } }
        public int nIdTipoEquipo { get; set; }
        public string sTipoEquipo { get; set; }
        public string sMarca { get; set; }
        public string sNumSerie { get; set; }
        public string sObservaciones { get; set; }
        public Decimal dbMontoPorCobrar
        {
            get
            {
                Decimal dbResult = 0;

                if (lstCostos.Count > 0)
                {
                    lstCostos.ForEach(item =>
                    {
                        dbResult = dbResult + item.mPorCobrar;
                    });
                }
                else
                {
                    dbResult = _dbMontoPorCobrar;
                }

                return dbResult;
            }
        }
        public Decimal dbMontoCobrado
        {
            get
            {
                Decimal dbResult = 0;

                if (lstCostos.Count > 0)
                {
                    lstCostos.ForEach(item =>
                    {
                        dbResult = dbResult + item.mCobrado;
                    });
                }
                else
                {
                    dbResult = _dbMontoCobrado;
                }

                return dbResult;
            }
        }
        public Decimal dbMontoNeto
        {
            get
            {
                Decimal dbResult = 0;

                if (lstCostos.Count > 0)
                {
                    lstCostos.ForEach(item =>
                    {
                        dbResult = dbResult + item.mNeto;
                    });
                }
                else
                {
                    dbResult = _dbMontoNeto;
                }

                return dbResult;
            }
        }
        public int nEstatus { get; set; }
        public string sEstatus { get; set; }
        public List<entTallerCosto> lstCostos { get; set; }
        public List<entCliente> lstPersonasRecoge { get; set; }
    }
}
