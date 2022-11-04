<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="java.util.Enumeration" %>
<%@ page import="Actividad1.ManejoTriangulo" %>
<!DOCTYPE html>
<html>
<head>
	<title>** ACTIVIDAD 3 ** Calcula Area y Perimetro de un Triangulo * Resultado *</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<script src="../js/jquery.min.js"></script>
	<script src="../js/popper.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
</head>
<body>
	<div class="container">
		<div class="row">
			<div class="col-md-12 text-center">
	       		<h1>ACTIVIDAD 3</h1>
				<h2>CALCULOS DE UN TRIANGULO * RESULTADOS *</h2>
	        </div>
		</div>
		<div class="row">
			<div class="col-md-3 text-center"></div>
			<div class="col-md-6 text-center">
				<fieldset class="col-12 col-md-12 px-3">
					<legend>Usuario registrado</legend>
					<div class="row justify-content-center">
						<div class="form-group col-sm-12 col-lg-12">
  							<%
								ManejoTriangulo mTriangulo = (ManejoTriangulo) request.getAttribute("mTrianguloResultado");

	  							HttpSession sesion = request.getSession(false);
	  				   			Enumeration lstSesion = sesion.getAttributeNames();
	  				   			if (lstSesion.hasMoreElements()) {
	  				   				out.print(sesion.getAttribute("Usuario"));
	  				   			}
	  				   			else {
	  				   				out.print("No se ingreso desde la pantalla de Usuario.");
	  				   			}
  							%>
  						</div>
  					</div>
  				</fieldset>
  			</div>
  		</div>
		<div class="row">
        	<div class="col-md-2"></div>
            <div class="col-md-2 text-right">Base: </div>
            <div class="col-md-2"><%= mTriangulo.getsBase() %></div>
            <div class="col-md-2 text-right">Altura </div>
            <div class="col-md-2"><%= mTriangulo.getsAltura() %></div>
            <div class="col-md-2"></div>
        </div>
        <div class="row">
			<div class="col-md-12"><h3>Datos operación AREA Y PERIMETRO</h3></div>
        </div>
		<div class="row">
			<div class="col-md-2"></div>
			<div class="col-md-3 text-right">Area: </div>
            <div class="col-md-5 text-xl-center alert-info"><%= mTriangulo.getArea() %></div>
            <div class="col-md-2"></div>
        </div>
        <div class="row">
			<div class="col-md-2"></div>
            <div class="col-md-3 text-right">Perimetro: </div>
            <div class="col-md-5 text-xl-center alert-info"><%= mTriangulo.getPerimetro() %></div>
            <div class="col-md-2"></div>
		</div>
        <div class="row">
        	<div class="col-md-3 text-right"></div>
            <div><label ></label></div>
        </div>
		<div class="row">
        	<div class="col-md-3 text-right"></div>
            <div class="col-md-3"><a href="a3_DTriangulo.jsp" class="btn btn-danger">Nuevo Calculo</a></div>
            <div class="col-md-3"><a href="../Index.html" class="btn btn-danger">Inicio</a></div>
            <div class="col-md-3"></div>
		</div>
	</div>
</body>
</html>