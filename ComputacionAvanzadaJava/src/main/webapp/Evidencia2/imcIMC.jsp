<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="java.io.IOException" %>
<%@ page import="java.util.Enumeration" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="Evidencia2.Entidades.*" %>
<!DOCTYPE html>
<html>
<head>
	<title>Evidencia 2: -IMC</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="../js/jquery.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</head>
<body>
	<form action="IMC" method="post">
		<% 
			String sUsuario = "???", sNombre = "No se ha ingresado correctamente.";
			int nEdad = 0;
			ArrayList<entIMC> lstIMC = null;
			
			HttpSession sesion = request.getSession(false);
			Enumeration lstSesion = sesion.getAttributeNames();
			if (lstSesion.hasMoreElements()) {
				entUsuario itemUser = (entUsuario) sesion.getAttribute("DatoUsuairo"); // request.getAttribute("DatoUsuairo");
				
				sUsuario = itemUser.getsUsuario();
				sNombre = itemUser.getsNombreCompleto();
				nEdad = itemUser.getnEdad();
				
				lstIMC = itemUser.getlstMIC();
			}
		%>
		<div class="container">
	    	<div class="row">
	        	<div class="col-md-12 text-center">
	        		<h1>EVIDENCIA 2</h1>
					<h2>IMC * Dato de Indice de Masa Corporal *</h2>
	            </div>
			</div>
			<div class="row">
				<div class="col-md-6 text-center"></div>
				<div class="col-md-6 text-center">
					<fieldset class="col-12 col-md-12 px-3">
						<legend>Usuario registrado</legend>
						<div class="row justify-content-center">
							<div class="form-group col-sm-12 col-lg-12">
								<div class="input-group">
									<% out.print(sUsuario + "-" + sNombre); %>
								</div>
	  						</div>
	  					</div>
  					</fieldset>
  				</div>
  			</div>
  			<div class="row">
  				<div class="col-md-2 text-right">Edad:</div>
  				<div class="col-md-4 text-left">
  					<input type="text" name="txtEdad" id="txtEdad" value="<% out.print(nEdad); %>" class="form-control" />
  				</div>
  				<div class="col-md-2 text-right">Fecha de medida:</div>
  				<div class="col-md-3 text-left">
  					<input type="text" name="txtFechaMedida" id="txtFechaMedida" class="form-control" />
  				</div>
  				<div class="col-md-1 text-left">
  					<code class="w3-codespan">DD/MM/AAAA</code>
  				</div>
  			</div>
  			<div class="row">
  				<div class="col-md-2 text-right">Tipo de unidad:</div>
  				<div class="col-md-10 text-left">
	  				<input type="radio" name="tUnidad" id="tUnidadM" value="Metrico" checked="checked" /><b>Metrico</b><code class="w3-codespan">(Kilos/Metros)</code>&nbsp;  
					<input type="radio" name="tUnidad" id="tUnidadI" value="Ingles" /><b>Ingles</b><code class="w3-codespan">(Libras/Pulgadas)</code>
  				</div>
  			</div>
			<div class="row">
				<div class="col-md-2 text-right">Peso:</div>
				<div class="col-md-4 text-left">
					<input type="text" name="txtPeso" id="txtPeso" class="form-control" />
				</div>
      			<div class="col-md-2 text-right">Estatura:</div>
      			<div class="col-md-4 text-left">
      				<input type="text" name="txtEstatura" id="txtEstatura" class="form-control" />
				</div>
			</div>
            <div class="row">
            	<div class="col-md-3">
            		
            	</div>
            	<div class="col-md-3 text-center">
            		<a href="imcLogin.jsp" class="btn btn-outline-primary">Autentificación</a>
            	</div>
            	<div class="col-md-3 text-center">
            		<input id="btAgregaIMC" type="submit" value="Agrega IMC" class="btn btn-success" />
            	</div>
            </div>
            <div class="row">
            	<div class="col-md-12">
            		<h5>Historial de IMC</h5>
            	</div>
            </div>
            <div class="row">
				<div class="col-md-12">
					<table class="table table-striped">
						<thead>
							<tr>
								<th>Fecha de medida</th>
								<th>Tipo de unidad</th>
								<th>Peso</th>
								<th>Estatura</th>
								<th>IMC</th>
								<th>Nivel peso</th>
							</tr>
						</thead>
						<tbody>
							<%
								if (lstIMC != null){
									for (int nR = 0; nR < lstIMC.size(); nR++){
										out.println("<tr><td>"+lstIMC.get(nR).getsdMedida()+"</td>");
										out.println("<td>"+lstIMC.get(nR).getsTiUnidad()+"</td>");
										out.println("<td>"+lstIMC.get(nR).getdPeso()+"</td>");
										out.println("<td>"+lstIMC.get(nR).getdEstatura()+"</td>");
										out.println("<td>"+lstIMC.get(nR).getdIMC()+"</td>");
										out.println("<td>"+lstIMC.get(nR).getsNivelPeso()+"</td></tr>");
									}
								}
							%>
						</tbody>
					</table>
				</div>
            </div>
        </div>
	</form>
</body>
</html>