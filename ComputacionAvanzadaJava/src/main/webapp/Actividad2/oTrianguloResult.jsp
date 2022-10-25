<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="Actividad1.ManejoTriangulo" %>
<!DOCTYPE html>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	    <title>** Actividad 2 ** Calculando . . . </title>
	    <link href="styles/bootstrap.min.css" rel="stylesheet" media="screen" />
	    <meta name="viewport" content="width=device-width, initial-scale=1" />
	    <script src="js/jquery.min.js"></script>
	    <script src="js/popper.min.js"></script>
	    <script src="js/bootstrap.min.js"></script>
	</head>
	<body>
    	<div class="container">
        	<div class="row">
            	<div class="col-md-12 text-center"> 
                	<h1>ACTIVIDAD 2</h1>
                	<h2>CALCULOS DE UN TRIANGULO</h2>
	                <%
	                    ManejoTriangulo mTriangulo = (ManejoTriangulo) request.getAttribute("mTrianguloResultado");
	                  %>
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
        </div>
        <div class="container">
        	<div class="row">
                <div class="col-md-3 text-right"></div>
                <div><label ></label></div>
            </div>
        </div>
        <div class="container">
        	<div class="row">
                <div class="col-md-3 text-right"></div>
                <div class="col-md-3"><a href="Actividad2/oTriangulo.jsp" class="btn btn-success">Nuevo Calculo</a></div>
                <div class="col-md-3"><a href="Index.html" class="btn btn-success">Inicio</a></div>
                <div class="col-md-3"></div>
            </div>
        </div>
    </body>
</html>