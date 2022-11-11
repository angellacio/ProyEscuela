package Evidencia2.Entidades;

import java.text.SimpleDateFormat;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeFormatterBuilder;
import java.util.ArrayList;

public class entUsuario {
	private int nIdUsuario;
    private String sUsuario;
    private String sContraseña;
    private String sNombreCompleto;
    private String sSexo;
    private entIMC itemUltimo;
    private ArrayList<entIMC> lstMIC;
    
    public entUsuario() {
    	nIdUsuario = -1;
    	sUsuario = "";
        sContraseña = "";
        sNombreCompleto = "";
        sSexo = "";
    	lstMIC = new ArrayList<entIMC>();
    }
    
    public int getnIdUsuario(){
        return nIdUsuario;
    }
    public void setnIdUsuario(int sValue){
    	nIdUsuario = sValue;
    }
    
    public String getsUsuario(){
        return sUsuario;
    }
    public void setsUsuario(String sValue){
    	sUsuario  = sValue;
    }

    public String getsContraseña(){
        return sContraseña;
    }
    public void setsContraseña(String sValue){
    	sContraseña = sValue;
    }
    
    public String getsNombreCompleto(){
        return sNombreCompleto;
    }
    public void setsNombreCompleto(String sValue){
    	sNombreCompleto = sValue;
    }
    
    public String getsSexo(){
        return sSexo;
    }
    public void setsSexo(String sValue){
    	sSexo = sValue;
    }
    
    public int getnEdad(){
    	buscaUltimoIMC();
    	
    	return itemUltimo.getnEdad();
    }
    public Double getnIMC(){
    	buscaUltimoIMC();

    	return itemUltimo.getdIMC();
    }
    
    public void buscaUltimoIMC() {
    	itemUltimo = new entIMC();
    	DateTimeFormatter simpleDateFormat = DateTimeFormatter.ofPattern("dd/MM/yyyy");

    	getlstMIC().forEach((itemIMC) -> {
    		if (itemIMC.getnIdIMC() > itemUltimo.getnIdIMC()) {
    			itemUltimo.setnIdIMC(itemIMC.getnIdIMC());
    			itemUltimo.setfMedida(simpleDateFormat.format(itemIMC.getfMedida()));
    			itemUltimo.setnEdad(itemIMC.getnEdad());
    			itemUltimo.setsTiUnidad(itemIMC.getsTiUnidad());
    			itemUltimo.setdEstatura(itemIMC.getdEstatura());
    			itemUltimo.setdPeso(itemIMC.getdPeso());
    			itemUltimo.setdIMC(itemIMC.getdIMC());
    			itemUltimo.setsNivelPeso(itemIMC.getsNivelPeso());
    		}
    	});
    }
    
    public ArrayList<entIMC> getlstMIC(){
        return lstMIC;
    }
    public void setlstMIC(ArrayList<entIMC> sValue){
    	lstMIC = sValue;
    }
}
