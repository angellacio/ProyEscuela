<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
	<title>Evidencia 2: -IMC- Alta de Usuarios</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="../js/jquery.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</head>
<body>
	<form action="IMC" method="post">
		<div class="container">
	    	<div class="row">
	        	<div class="col-md-12 text-center">
	        		<h1>EVIDENCIA 2</h1>
					<h2>IMC * Alta de Usuario * </h2>
	            </div>
			</div>
  			<div class="row">
  				<div class="col-md-2 text-right">Nombre completo:</div>
  				<div class="col-md-4 text-left">
  					<input type="text" name="txtNombre" id="txtNombre" value="" class="form-control" />
  				</div>
  				<div class="col-md-2 text-right">Sexo:</div>
  				<div class="col-md-4 text-left">
  					<input type="radio" name="tSexo" id="tSexoF" value="Femenino" checked="checked" /><b>Femenino</b>&nbsp;  
					<input type="radio" name="tSexo" id="tSexoM" value="Masculino" /><b>Masculino</b>
  				</div>
  			</div>
  			<div class="row">
  				<div class="col-md-2 text-right">Usuario:</div>
  				<div class="col-md-4 text-left">
  					<input type="text" name="txtUsuario" id="txtUsuario" class="form-control" />
  				</div>
  				<div class="col-md-2 text-right">Contraseña:</div>
  				<div class="col-md-4 text-left">
  					<input type="text" name="txtContrasenia" id="txtContrasenia" class="form-control" />
  				</div>
  			</div>
  			<div class="row">
  				<div class="col-md-2 text-right"></div>
  				<div class="col-md-3 text-center">
  					<a href="imcLogin.jsp" class="btn btn-outline-primary">Autentificación</a>
  				</div>
  				<div class="col-md-3 text-center">
  					<input id="btAgregaIMC" type="submit" value="Agrega Usuario" class="btn btn-success" />
  				</div>
  			</div>
  		</div>
  	</form>
</body>
</html>