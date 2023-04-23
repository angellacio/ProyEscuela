package Usuario.Modelo;

import java.util.ArrayList;
import javax.management.InvalidApplicationException;

public class manejoUsuario {
	public Usuario.Entidad.entUsuario validaCredenciales(String sUsuario, String sContrasenia) throws InvalidApplicationException {
		Usuario.Entidad.entUsuario itemUser = null;
		ArrayList<String> lstMenu = null;
		try {
			if (sUsuario.equals("Admin") && sContrasenia.equals("321456987")) {
				lstMenu = new ArrayList<String>();
				
				lstMenu.add("");
				
				itemUser = new Usuario.Entidad.entUsuario(); 
				itemUser.setnIdUsuario(-1);
				itemUser.setsNombreCompleto("Usuario Adminsitrador SISTEMAS");
				itemUser.setsUsuario("Admin");
				itemUser.setsContraseña("******");
				itemUser.setsSexo("M");
				itemUser.setlstMIC(lstMenu);
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
