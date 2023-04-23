package Usuario.Entidad;

import java.util.ArrayList;

public class entUsuario {
	private int nIdUsuario;
    private String sUsuario;
    private String sContraseña;
    private String sNombreCompleto;
    private String sSexo;
    private ArrayList<String> lstMenu;
    
    public entUsuario() {
    	nIdUsuario = -1;
    	sUsuario = "";
        sContraseña = "";
        sNombreCompleto = "";
        sSexo = "";
        lstMenu = new ArrayList<String>();
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
    
    public ArrayList<String> getlstMIC(){
        return lstMenu;
    }
    public void setlstMIC(ArrayList<String> sValue){
    	lstMenu = sValue;
    }
}
