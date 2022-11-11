package Evidencia2.Modelo;

import java.io.IOException;
import java.util.ArrayList;

import javax.management.InvalidApplicationException;

public class manejoIMC {
	public ArrayList<Evidencia2.Entidades.entIMC> consultaIMC(int nIdUsuario) {
		ArrayList<Evidencia2.Entidades.entIMC> result = null;
		Evidencia2.Entidades.entIMC item = null;
		try {
			result = new ArrayList<Evidencia2.Entidades.entIMC>();
			
			item = new Evidencia2.Entidades.entIMC();
			item.setnIdIMC(0);
			item.setnUsuairo(-1);
			item.setfMedida("08/11/2022");
			item.setnEdad(39);
			item.setsTiUnidad("M");
			item.setdPeso(115.84);
			item.setdEstatura(1.79);
			item.generaIMC();
			result.add(item);
			
			item = new Evidencia2.Entidades.entIMC();
			item.setnIdIMC(0);
			item.setnUsuairo(-1);
			item.setfMedida("01/11/2022");
			item.setnEdad(39);
			item.setsTiUnidad("M");
			item.setdPeso(115.23);
			item.setdEstatura(1.79);
			item.generaIMC();
			result.add(item);
			
		} catch (Exception ex) {
			
		}
		finally { }
		return result;
	}
	public void altaIMC(Evidencia2.Entidades.entIMC itemIMC) {
		try {
			
		} catch (Exception ex) {
			
		}
		finally { }
	}
}
