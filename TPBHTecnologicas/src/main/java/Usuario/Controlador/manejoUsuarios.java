package Usuario.Controlador;

import java.io.IOException;
import javax.management.InvalidApplicationException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

@WebServlet(name = "/Usuario/manejoUsuarios", urlPatterns = {"/Usuario/manejoUsuarios"})
public class manejoUsuarios extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	public manejoUsuarios() {
		
    }

    protected void procesaRequerimiento(HttpServletRequest request, HttpServletResponse response) {
    	response.setContentType("text/html;charset=UTF-98");
    	Usuario.Entidad.entUsuario itemUser = null;
    	Usuario.Modelo.manejoUsuario consDatos = null;
    	String sUsuario = "", sContrasenia = "", sMensaje = "Proceso correcto.", sPagina = "imcIMC.jsp";
    	int nMensaje = 1;
    	    	
    	try {
        	sUsuario = request.getParameter("txtUsuario").trim();
        	sContrasenia = request.getParameter("txtContrasenia").trim();
        	
        	consDatos = new Usuario.Modelo.manejoUsuario();
			itemUser = consDatos.validaCredenciales(sUsuario, sContrasenia);
			
	    	
		} catch (InvalidApplicationException ex) {
			sPagina = "../login.jsp";
			nMensaje = -1;
			sMensaje = "Error en las credenciales";
		} catch (Exception ex) {
			sPagina = "../login.jsp";
			nMensaje = -2;
			sMensaje = "Error al ingresar. " + ex.toString();
    	}
    	finally { }
    	
    	try {
    		HttpSession sesion = request.getSession(false);
	    	sesion.setAttribute("DatoUsuairo", itemUser);
	    	
    		request.setAttribute("DatoUsuairo", itemUser);
        	request.setAttribute("nMensaje", nMensaje);
        	request.setAttribute("sMensaje", sMensaje);
        	request.getRequestDispatcher(sPagina).forward(request, response);
    	}
    	catch (Exception ex){}
    }
    
    @Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

	}

    @Override
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
    	procesaRequerimiento(request, response);
	}
	@Override
    public String getServletInfo() {
    	return "Valida datos de autentificación.";
    }
}
