package Evidencia2.Entidades;

import java.time.*;
import java.time.format.DateTimeFormatter;
import java.lang.Exception;

public class entIMC {
	private int nIdIMC;
	private int nUsuario;
	private LocalDateTime fMedida;
	private int nEdad;
	private String sTiUnidad;
	private double dEstatura;
	private double dPeso;
	private double dIMC;
	private String sNivelPeso;
	
	public entIMC() {
		nIdIMC = -50;
		nUsuario = -50;
		fMedida = LocalDateTime.of(1982, Month.DECEMBER, 07, 00, 00, 00);
		nEdad = -50;
		sTiUnidad = "";
		dEstatura = 0.0;
		dPeso = 0.0;
		dIMC = 0.0;
		sNivelPeso = "";
	}
		
    public int getnIdIMC(){
        return nIdIMC;
    }
    public void setnIdIMC(int sValue){
    	nIdIMC  = sValue;
    }
    
    public int getnUsuario(){
        return nUsuario;
    }
    public void setnUsuairo(int sValue){
    	nUsuario  = sValue;
    }
    
    public LocalDateTime getfMedida(){
        return fMedida;
    }
    public String getsdMedida(){
    	DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        return fMedida.format(formatter);
    }
    public void setfMedida(String sValue){
    	LocalDateTime dResult = LocalDateTime.of(1982, Month.DECEMBER, 07, 00, 00, 00);
    	try{
    		String[] sArray = sValue.split("/");
    		int nDia = 0, nMes = 0, nAnio = 0;
    		for (int nR = 0; nR < sValue.length(); nR++) {
    			if (nR == 0) {
    				nDia = Integer.parseInt(sArray[nR]);
    			}
    			if (nR == 1) {
    				nMes = Integer.parseInt(sArray[nR]);
    			}
    			if (nR == 2) {
    				nAnio = Integer.parseInt(sArray[nR]);
    			}
    		}
    		dResult = LocalDateTime.of(nAnio, nMes, nDia, 0, 0);
    	}
    	catch (Exception ex) { }
    	finally { }
    	fMedida = dResult;
    }
    
    public int getnEdad(){
        return nEdad;
    }
    public void setnEdad(int sValue){
    	nEdad = sValue;
    }
    
    public String getsTiUnidad(){
        return sTiUnidad;
    }
    public void setsTiUnidad(String sValue){
    	sTiUnidad = sValue;
    }
    
    public Double getdEstatura(){
        return dEstatura;
    }
    public void setdEstatura(Double sValue){
    	dEstatura = sValue;
    }
    
    public Double getdPeso(){
        return dPeso;
    }
    public void setdPeso(Double sValue){
    	dPeso = sValue;
    }
    
    public Double getdIMC(){
        return dIMC;
    }
    public void setdIMC(Double sValue){
    	dIMC = sValue;
    }
    
    public String getsNivelPeso(){
        return sNivelPeso;
    }
    public void setsNivelPeso(String sValue){
    	sNivelPeso = sValue;
    }

    public void generaIMC(){
    	if (nEdad >= 20) {
	    	if (sTiUnidad.equals("M")) dIMC = dPeso / (dEstatura * dEstatura);
	    	else dIMC = (dPeso / (dEstatura * dEstatura)) * 703;

	    	if (dIMC <= 18.5) sNivelPeso = "Bajo peso";
	    	else if (dIMC > 18.5 && dIMC <= 24.9) sNivelPeso = "Normal";
	    	else if (dIMC > 24.9 && dIMC <= 30.0) sNivelPeso = "Sobrepeso";
	    	else if (dIMC > 30.0) sNivelPeso = "Obesidad";
    	}
    	else {
    		sNivelPeso = "Fuera del rango de edad. Edad minima 20 años.";
    	}
    }
}
