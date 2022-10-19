<%-- 
    Document   : operacionTriangulo
    Created on : 18/10/2022
--%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ page import="Actividad1.ManejoTriangulo" %>
<!DOCTYPE html>
<html>
<head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Calculando . . . </title>
        <link href="styles/bootstrap.min.css" rel="stylesheet" media="screen">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <script src="js/jquery.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </head>
    <body>
    	<div class="container">
        	<div class="row">
            	<div class="col-md-12 text-center"> 
                	<h1>CALCULA AREA Y PERIMETRO DE UN TRIANGULO</h1>
	                <%
	                    String sBase = request.getParameter("txtBase");
	                    String sAltura = request.getParameter("txtAltura");
	                    
	                    ManejoTriangulo mTriangulo = new ManejoTriangulo(sAltura, sBase);
	                    mTriangulo.calculaArea();
	                    mTriangulo.calculaPromedio();
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
                <div class="col-md-12"><h2>Datos operación</h2></div>
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
                <div class="col-md-3"><a href="oTriangulo.html" class="btn btn-success">Nuevo Calculo</a></div>
                <div class="col-md-3"><a href="Index.html" class="btn btn-success">Inicio</a></div>
                <div class="col-md-3"></div>
            </div>
        </div>
    </body>
</html>