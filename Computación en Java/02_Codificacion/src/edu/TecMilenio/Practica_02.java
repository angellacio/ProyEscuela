package edu.TecMilenio;
import java.io.*;
import java.util.LinkedHashSet;

public class Practica_02 {
    private static BufferedReader datoCaptura = new BufferedReader(new InputStreamReader(System.in));

    public static void GeneraCalificacion() {
        String sEstudinate = "";
        Double[] dbCalificaciones = null;
        Double dbPromedio = 0.0;
        try {
            System.out.print("Favor de ingresar el Nombre del Estudiante: ");
            sEstudinate = datoCaptura.readLine().toString().trim().toUpperCase();
            dbCalificaciones = ObtenCalificaciones(5, 0);
            dbPromedio = CalculaPromedio(dbCalificaciones);
            ImprimirPantalla(sEstudinate, dbCalificaciones, dbPromedio, CalificacionFinal(dbPromedio));
        }
        catch (Exception ex){

        }
    }
    private static Double[] ObtenCalificaciones(int nTamArreglo, int nRenglonCont) {
        Double[] dbResult = new Double[nTamArreglo];
        try{
            do {
                dbResult[nRenglonCont] = ObtenCalificaciones(nRenglonCont);
                nRenglonCont ++;
            } while (nRenglonCont <= (nTamArreglo -1));
        }
        catch(Exception ex) { }
        finally { }
        return dbResult;
    }
    private static Double ObtenCalificaciones(int nRenglonCont) {
        Double dbResult = 0.0;
        try{
            System.out.print("Calificación " + (nRenglonCont + 1) + ":  ");
            dbResult = Double.parseDouble(datoCaptura.readLine());
            if (dbResult < 0 || dbResult > 100) throw new IOException("La calificación ingresada es errónea.");
            dbResult = Math.round(dbResult * 100.00) / 100.00;
        }
        catch(IOException | NumberFormatException ex) {
            System.out.print(" El tipo de dato ingresado no es un numero, ingresar una Calificación valido. ");
            dbResult =ObtenCalificaciones(nRenglonCont);
        }
        finally { }
        return dbResult;
    }
    private static Double CalculaPromedio(Double[] dbCalificaciones){
        Double dbResult = 0.0;
        Integer nConteo = 0;
        try {
            for (nConteo = 0; nConteo < dbCalificaciones.length; nConteo++)
            {
                dbResult = dbResult + dbCalificaciones[nConteo];
            }
            dbResult = Math.round((dbResult / dbCalificaciones.length) * 100.00) / 100.00;
        }
        catch (Exception ex){

        }
        return dbResult;
    }
    private static String CalificacionFinal (Double dbPromedio){
        String sResult = "A";

        if (dbPromedio >= 51.00 && dbPromedio <= 60.99) sResult = "E";
        else if (dbPromedio >= 61.00 && dbPromedio <= 70.99) sResult = "D";
        else if (dbPromedio >= 71.00 && dbPromedio <= 80.99) sResult = "C";
        else if (dbPromedio >= 81.00 && dbPromedio <= 90.99) sResult = "B";
        else if (dbPromedio >= 91.00 && dbPromedio <= 100.99) sResult = "A";
        else sResult = "F";

        return sResult;
    }
    private static void ImprimirPantalla(String sNombre, Double[] dbCalificaciones, Double dbPromedio, String sCalificacion) {
        Integer nConteo = 0;
        System.out.println("");
        System.out.println("");
        System.out.println("                      Nombre del estudiante: " + sNombre);
        for (nConteo = 0; nConteo < dbCalificaciones.length; nConteo++)
        {
            System.out.println("                             Calificación " + (nConteo + 1) + ": " + dbCalificaciones[nConteo]);
        }
        System.out.println("                                   Promedio: " + dbPromedio);
        System.out.println("                               Calificación: " + sCalificacion);
    }


}
