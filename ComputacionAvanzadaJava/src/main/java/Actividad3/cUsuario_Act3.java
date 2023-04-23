package Actividad3;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

@WebServlet(name = "/Actividad3/cUsuario_Act3", urlPatterns = {"/Actividad3/cUsuario_Act3"})
public class cUsuario_Act3 extends HttpServlet {
	private static final long serialVersionUID = 1L;

    public cUsuario_Act3() {

    }

    protected void procesaRequerimiento(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
    	response.setContentType("text/html;charset=UTF-98");
    	String sNombre = request.getParameter("txtNombre").trim().toUpperCase();
    	
    	HttpSession sesion = request.getSession(false);
    	sesion.setAttribute("Usuario", sNombre);
    	
    	request.setAttribute("sUsuarioResultado", sNombre);
    	request.getRequestDispatcher("a3_DTriangulo.jsp").forward(request, response);
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
    	return "Obten datos de usuario para la Actividad 3.";
    }
}
