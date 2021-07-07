package edu.TecMilenio;
import java.io.*;
import java.util.LinkedHashSet;

public class Main {
    private static BufferedReader datoCaptura = new BufferedReader(new InputStreamReader(System.in));

    public static void main(String[] args) {
        String sOpcion = "";
        boolean bolSigeProceso = true;
        try {
            do{
                System.out.println("----------------------------   Programación  JAVA - MENU   ---------------------------");
                System.out.println("1 - Practica 01. Hola Mundo");
                System.out.println("2 - Practica 02. Calificaciones");
                System.out.println("X/x - Termina el programa.");
                System.out.println("--------------------------------------------------------------------------------------");
                System.out.print("Favor de especificar la opción deseada: ");
                sOpcion = datoCaptura.readLine().toString().trim().toUpperCase();
                switch(sOpcion)
                {
                    case "1":
                        System.out.println("\n\n\n\n");
                        System.out.println("   ********************************   Hola Mundo   ********************************   ");
                        Practica_01.HolaMundo();
                        System.out.println("   ***********************************   F I N   **********************************   ");
                        System.out.print("Presione ENTER para continuar.");
                        System.out.println("\n\n");
                        datoCaptura.readLine().toString().trim().toUpperCase();

                        break;
                    case "2":
                        System.out.println("\n\n\n\n");
                        System.out.println("   ******************************   Calificaciones   ******************************   ");
                        Practica_02.GeneraCalificacion();
                        System.out.println("   ***********************************   F I N   **********************************   ");
                        System.out.print("Presione ENTER para continuar.");
                        System.out.println("\n\n");
                        datoCaptura.readLine().toString().trim().toUpperCase();
                        break;
                    case "X":
                        bolSigeProceso = false;
                        break;
                    default:
                        System.out.println("");
                        System.out.println("El tipo de dato ingresado no es correcto, ingresar un dato valido.");
                        System.out.println("");
                        break;
                }
            } while (bolSigeProceso);

        }
        catch (Exception ex) {
            System.out.println(ex.getMessage());
            System.out.println("");
        }

    }
}
