<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="Actividad2.cOperaTriangulo" %>
<!DOCTYPE html>
<html>
<head>
    <title>** ACTIVIDAD 2 ** Calcula Area y Perimetro de un Triangulo</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="../js/jquery.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</head>
    <body>
        <form action="../cOperaTriangulo" method="post">
            <div class="row">
                <div class="col-md-12 text-center">
                    <h1>ACTIVIDAD 2</h1>
                	<h2>CALCULOS DE UN TRIANGULO</h2>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-3 text-right">Base: </div>
                    <div class="col-md-6"><input id="txtBase" name="txtBase" type="text" class="text-primary" /></div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-3 text-right">Altura: </div>
                    <div class="col-md-6"><input id="txtAltura" name="txtAltura" type="text" class="text-primary" /></div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-3"><a href="../Index.html" class="btn btn-success">Inicio...</a></div>
                    <div class="col-md-6"><input id="btCalula" type="submit" value="Calcular" class="btn btn-success" /></div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-6"></div>
                </div>
            </div>
        </form>
    </body>
</html>