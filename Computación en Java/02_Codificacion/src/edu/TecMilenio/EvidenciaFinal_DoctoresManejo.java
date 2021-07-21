package edu.TecMilenio;

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class EvidenciaFinal_DoctoresManejo {
    private static BufferedReader datoCaptura = new BufferedReader(new InputStreamReader(System.in));
    public static void MuestraMenuDoctores() {
        String sOpcion = "";
        try {
            System.out.println("   ** Manejo de consultas Medicas - Doctores **");
            System.out.println("        1 - Altas");
            System.out.println("        2 - Cambios");
            System.out.println("        3 - Bajas");
            System.out.println("        X/x - Regresar Menu Consulta Medica.");
            System.out.print("Favor de especificar la opción deseada: ");

            sOpcion = datoCaptura.readLine().toString().trim().toUpperCase();

            switch (sOpcion) {
                case "1":
                    Alta();
                    break;
                case "2":
                    Cambios();
                    break;
                case "3":
                    Borrar();
                    break;
                case "X":
                    break;
                default:
                    System.out.println("");
                    System.out.println("El tipo de dato ingresado no es correcto, ingresar un dato valido.");
                    System.out.println("");
                    MuestraMenuDoctores();
                    break;
            }
        }
        catch (Exception ex){}
        finally { }

    }

    public static void Alta() {
        try {

        }
        catch (Exception ex){
            System.out.println("¡¡ ERROR !!" + ex.getMessage());
        }
    }
    public static void Cambios() {
        try {

        }
        catch (Exception ex){
            System.out.println("¡¡ ERROR !!" + ex.getMessage());
        }
    }
    public static void Borrar() {
        try {

        }
        catch (Exception ex){
            System.out.println("¡¡ ERROR !!" + ex.getMessage());
        }
    }
    public static void Consulta() {
        try {

        }
        catch (Exception ex){
            System.out.println("¡¡ ERROR !!" + ex.getMessage());
        }
    }
}
