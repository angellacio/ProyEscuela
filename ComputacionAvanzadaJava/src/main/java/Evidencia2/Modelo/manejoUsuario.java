package Evidencia2.Modelo;

import java.util.ArrayList;

import javax.management.InvalidApplicationException;

public class manejoUsuario {
	public Evidencia2.Entidades.entUsuario validaCredenciales(String sUsuario, String sContrasenia) throws InvalidApplicationException {
		Evidencia2.Entidades.entUsuario itemUser = null;
		ArrayList<Evidencia2.Entidades.entIMC> lstIMC = null;
		try {
			if (sUsuario.equals("Admin") && sContrasenia.equals("321456987")) {
				lstIMC = new ArrayList<Evidencia2.Entidades.entIMC>();
				Evidencia2.Entidades.entIMC itemIMC = null;
				
				itemIMC = new Evidencia2.Entidades.entIMC();
				itemIMC.setnIdIMC(0);
				itemIMC.setnUsuairo(-1);
				itemIMC.setfMedida("01/11/2022");
				itemIMC.setnEdad(39);
				itemIMC.setsTiUnidad("M");
				itemIMC.setdPeso(115.23);
				itemIMC.setdEstatura(1.79);
				itemIMC.generaIMC();
				lstIMC.add(itemIMC);
				
				itemUser = new Evidencia2.Entidades.entUsuario(); 
				itemUser.setnIdUsuario(-1);
				itemUser.setsNombreCompleto("Usuario Adminsitrador SISTEMAS");
				itemUser.setsUsuario("Admin");
				itemUser.setsContraseña("******");
				itemUser.setsSexo("M");
				itemUser.setlstMIC(lstIMC);
				
				itemUser.buscaUltimoIMC();
			}
			else {
				throw new InvalidApplicationException("Las credenciales ingresadas no son validas.");	
			}
		}
		catch (Exception ex) {
			throw new InvalidApplicationException("Error al validar las credenciales");
		}
		finally {
		
		}
		return itemUser;
	}
}
