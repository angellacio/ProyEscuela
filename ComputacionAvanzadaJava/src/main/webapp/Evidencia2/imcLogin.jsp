<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="java.util.Enumeration" %>
<%@ page import="Evidencia2.Entidades.entUsuario" %>
<%@ page import="Evidencia2.Controlador.Usuairo" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
	<title>Evidencia 2: -IMC- Autentificación</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="../js/jquery.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</head>
<body>
	<form action="Usuairo" method="post">
		<div class="container">
	    	<div class="row">
	        	<div class="col-md-12 text-center">
	        		<h1>EVIDENCIA 2</h1>
					<h2>IMC * Autentificación *</h2>
	            </div>
			</div>
			<div class="row">
				<div class="col-md-12 text-center">
					<label id="lblMensaje" class="text-danger">
					<%
						entUsuario itemUser = null;
						int nMensaje = 0;
						String sMensaje = "";
						
						if (request.getAttribute("DatoUsuairo") != null) itemUser = (entUsuario) request.getAttribute("DatoUsuairo");
						if (request.getAttribute("nMensaje") != null) nMensaje = (int) request.getAttribute("nMensaje");
						if (request.getAttribute("sMensaje") != null) sMensaje = (String) request.getAttribute("sMensaje");
						
						if (nMensaje < 0){
							out.print(sMensaje);
						}
					%>
					</label>
				</div>
  			</div>
            <div class="row">
            	<div class="col-md-3 text-right">Usuario: </div>
                <div class="col-md-6">
                	<input id="txtUsuario" name="txtUsuario" type="text" class="form-control" />
                </div>
            </div>
            <div class="row">
            	<div class="col-md-3 text-right">Contraseña: </div>
                <div class="col-md-6">
                	<input id="txtContrasenia" name="txtContrasenia" type="text" class="form-control" />
                </div>
            </div>
            <div class="row">
            	<div class="col-md-3"></div>
            	<div class="col-md-3 text-center">
            		<input id="btIngresar" type="submit" value="Ingresar" class="btn btn-success" />
            	</div>
            	<div class="col-md-3 text-center">
            		<a href="imcUsuarios.jsp" class="btn btn-outline-primary">Alta de Usuario</a>
            	</div>
            </div>
            <div class="row">
				<div class="col-md-3"></div>
                <div class="col-md-6"></div>
            </div>
        </div>
	</form>
</body>
</html>