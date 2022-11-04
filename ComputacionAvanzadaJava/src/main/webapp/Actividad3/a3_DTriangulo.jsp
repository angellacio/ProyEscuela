<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="java.util.Enumeration" %>
<%@ page import="Actividad3.cOT_Act3" %>
<!DOCTYPE html>
<html>
<head>
	<title>** ACTIVIDAD 3 ** Calcula Area y Perimetro de un Triangulo</title>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<link href="../styles/bootstrap.min.css" rel="stylesheet" media="screen">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<script src="../js/jquery.min.js"></script>
	<script src="../js/popper.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
</head>
<body>
	<form action="cOT_Act3" method="post">
		<div class="container">
			<div class="row">
				<div class="col-md-12 text-center">
	        		<h1>ACTIVIDAD 3</h1>
					<h2>CALCULOS DE UN TRIANGULO</h2>
	            </div>
			</div>
			<div class="row">
				<div class="col-md-6 text-center">
					<fieldset class="col-12 col-md-12 px-3">
						<legend>Usuario registrado</legend>
						<div class="row justify-content-center">
							<div class="form-group col-sm-12 col-lg-12">
	  							<%
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
	  			<div class="col-md-6 text-center">
					<fieldset class="col-12 col-md-12 px-3">
						<legend>Ultimo calculo generado</legend>
						<div class="row justify-content-center">
							<div class="form-group col-sm-12 col-lg-12">
								<%
									Cookie gCalcTrinagulo[] = request.getCookies();
									if (gCalcTrinagulo != null && gCalcTrinagulo.length > 0) {
										for (int nR = 0; nR < gCalcTrinagulo.length; nR++){
											String sName = gCalcTrinagulo[nR].getName(); 
											if (sName.equals("Base")){
												out.print("BASE: "+gCalcTrinagulo[nR].getValue());
											}
											if (sName.equals("Altura")){
												out.print(" ALTURA: "+gCalcTrinagulo[nR].getValue());
											}
											if (sName.equals("Area")){
												out.print("<br />");
												out.print("AREA: "+gCalcTrinagulo[nR].getValue());
											}
											if (sName.equals("Perimetro")){
												out.print(" PERIMETRO: "+gCalcTrinagulo[nR].getValue());
											}
										}
									}
									else {
										out.print("No se ha realizado ningun calculo.");
									}
								%>
	  						</div>
	  					</div>
	  				</fieldset>
	  			</div>
			</div>
			<div class="row">
				<div class="col-md-3 text-right">Base: </div>
				<div class="col-md-6"><input id="txtBase" name="txtBase" type="text" class="form-control" /></div>
			</div>
			<div class="row">
              	<div class="col-md-3 text-right">Altura: </div>
				<div class="col-md-6">
					<input id="txtAltura" name="txtAltura" type="text" class="form-control" />
				</div>
			</div>
			<div class="row">
				<div class="col-md-3"><a href="a3_consUsuario.jsp" class="btn btn-danger">Inicio...</a></div>
				<div class="col-md-6">
					<input id="btCalula" type="submit" value="Calcular" class="btn btn-success" />
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