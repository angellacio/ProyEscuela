package Actividad2;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet(name = "/cOperaTriangulo", urlPatterns = {"/cOperaTriangulo"})
public class cOperaTriangulo extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    protected void procesaRequerimiento(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
    	response.setContentType("text/html;charset=UTF-98");
    	String sBase = request.getParameter("txtBase");
    	String sAltura = request.getParameter("txtAltura");
    	Actividad1.ManejoTriangulo mTriangulo = new Actividad1.ManejoTriangulo(sAltura, sBase);
    	
    	mTriangulo.calculaArea();
    	mTriangulo.calculaPromedio();
    	
    	request.setAttribute("mTrianguloResultado", mTriangulo);
    	request.getRequestDispatcher("Actividad2/oTrianguloResult.jsp").forward(request, response);
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
    	return "Calcula Area y Perimetro de un triangulo.";
    }
}
