using System;

namespace Electronica_Entidades
{
    [Serializable]
    public class entCatalogoSencillo
    {
        public entCatalogoSencillo(int ID, string tID, string Acronimo, string Descripcion, Boolean Estado)
        {
            inicializaComponente(ID, tID, Acronimo, Descripcion, Estado, "", null);
        }
        public entCatalogoSencillo(int ID, string tID, string Acronimo, string Descripcion, Boolean Estado, string sText, object sValue)
        {
            inicializaComponente(ID, tID, Acronimo, Descripcion, Estado, sText, sValue);
        }
        public entCatalogoSencillo()
        {
            inicializaComponente(-1, "", "", "", false, "", -1);
        }
        private void inicializaComponente(int ID, string tID, string Acronimo, string Descripcion, Boolean Estado, string sText, object sValue)
        {
            nID = ID;
            sID = tID;
            sAcronimo = Acronimo;
            sDescripcion = Descripcion;
            bEstado = Estado;
            Text = sText;
            Value = sValue;
        }

        public override string ToString()
        {
            return Text;
        }

        public int nID { get; set; }
        public string sID { get; set; }
        public string sAcronimo { get; set; }
        public string sDescripcion { get; set; }
        public Boolean bEstado { get; set; }

        public string Text { get; set; }
        public object Value { get; set; }
    }
}
