package Evidencia2.Controlador;

import java.io.IOException;
import java.util.ArrayList;

import javax.management.InvalidApplicationException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

@WebServlet(name = "/Evidencia2/IMC", urlPatterns = {"/Evidencia2/IMC"})
public class IMC extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public IMC() {

    }
    
    protected void procesaRequerimiento(HttpServletRequest request, HttpServletResponse response) {
    	response.setContentType("text/html;charset=UTF-98");
    	Evidencia2.Entidades.entUsuario itemUser = null;
    	ArrayList<Evidencia2.Entidades.entIMC> lstIMC = null;
    	Evidencia2.Entidades.entIMC itemIMC = null;
    	Evidencia2.Modelo.manejoIMC consDatos = null;
    	String sEdad = "", sFechaMedia = "", sTipoUnidad = "", sEstatura = "" , sPeso = "", sMensaje = "Proceso correcto.", sPagina = "imcIMC.jsp";
    	int nMensaje = 1;
    	    	
    	try {
    		itemIMC = new Evidencia2.Entidades.entIMC();
    		HttpSession sesion = request.getSession(false);
	    	itemUser = (Evidencia2.Entidades.entUsuario) sesion.getAttribute("DatoUsuairo");
    		lstIMC = itemUser.getlstMIC(); 
    				
    		sEdad = request.getParameter("txtEdad").trim();
        	sFechaMedia = request.getParameter("txtFechaMedida").trim();
        	sTipoUnidad = request.getParameter("tUnidad").trim();
        	sPeso = request.getParameter("txtPeso").trim();
        	sEstatura = request.getParameter("txtEstatura").trim();
        	
        	itemIMC.setnIdIMC(-1);
        	itemIMC.setnUsuairo(itemUser.getnIdUsuario());
        	itemIMC.setnEdad(Integer.parseInt(sEdad));
        	itemIMC.setfMedida(sFechaMedia);
        	if (sTipoUnidad.equals("Metrico")) itemIMC.setsTiUnidad("M");
        	else itemIMC.setsTiUnidad("I");
			itemIMC.setdPeso(Double.parseDouble(sPeso));
			itemIMC.setdEstatura(Double.parseDouble(sEstatura));
			itemIMC.generaIMC();
			
        	consDatos = new Evidencia2.Modelo.manejoIMC();
			consDatos.altaIMC(itemIMC);
			
			lstIMC = consDatos.consultaIMC(itemUser.getnIdUsuario());
			
			itemUser.setlstMIC(lstIMC);
			itemUser.buscaUltimoIMC();
	    	
		} catch (Exception ex) {
			sPagina = "imcIMC.jsp";
			nMensaje = -2;
			sMensaje = "Error al ingresar. " + ex.toString();
    	}
    	finally { }
    	
    	try {
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
		// TODO Auto-generated method stub
		procesaRequerimiento(request, response);
	}
	@Override
    public String getServletInfo() {
    	return "Valida datos de IMC.";
    }
}
