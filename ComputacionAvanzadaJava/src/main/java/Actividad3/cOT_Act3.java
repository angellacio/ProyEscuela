package Actividad3;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet(name = "/Actividad3/cOT_Act3", urlPatterns = {"/Actividad3/cOT_Act3"})
public class cOT_Act3 extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public cOT_Act3() {    }
    
    protected void procesaRequerimiento(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
    	response.setContentType("text/html;charset=UTF-98");
    	String sBase = request.getParameter("txtBase");
    	String sAltura = request.getParameter("txtAltura");
    	Actividad1.ManejoTriangulo mTriangulo = new Actividad1.ManejoTriangulo(sAltura, sBase);
    	
    	mTriangulo.calculaArea();
    	mTriangulo.calculaPerimetro();
    
    	Cookie ck = new Cookie("Base", mTriangulo.getsBase());
    	response.addCookie(ck);
    	ck = new Cookie("Altura", mTriangulo.getsAltura());
    	response.addCookie(ck);
    	ck = new Cookie("Area", mTriangulo.getArea()+"");
    	response.addCookie(ck);
    	ck = new Cookie("Perimetro", mTriangulo.getPerimetro()+"");
    	response.addCookie(ck);
    	
    	request.setAttribute("mTrianguloResultado", mTriangulo);
    	request.getRequestDispatcher("a3_DTrianguloResult.jsp").forward(request, response);
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
    	return "Calcula Area y Perimetro de un triangulo con Sesion y Cookie.";
    }
}
