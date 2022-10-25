package Actividad1;
import java.lang.Exception;
/**
*
* @author Angel Ramírez Mancera
*/
public class ManejoTriangulo {
	private String sAltura;
    private String sBase;
    private double Altura;
    private double Base;
    private double Area;
    private double Perimetro;

    public ManejoTriangulo(String saltura, String sbase) {
    	try {
    		sAltura = saltura;
    		sBase = sbase;
	        this.setAltura(Double.parseDouble(saltura));
	        this.setBase(Double.parseDouble(sbase));
    	}
    	catch (Exception ex) { }
    	finally { }
    }

    public String getsAltura(){
        return sAltura;
    }
    public void setsAltura(String saltura){
        sAltura = saltura;
    }
    
    public String getsBase(){
        return sBase;
    }
    public void setsBase(String sbase){
        sBase = sbase;
    }
    
    public double getAltura(){
        return Altura;
    }
    public void setAltura(double altura){
        Altura = altura;
    }
    
    public double getBase(){
        return Base;
    }
    public void setBase(double base){
        Base = base;
    }
    
    public void calculaArea(){
        Area = (getBase() * getAltura()) / 2;
    }
    public void calculaPromedio(){
        Perimetro = getBase() * 3;
    }
    
    public double getArea(){
        return Area;
    }
    public double getPerimetro(){
        return Perimetro;
    }
}
