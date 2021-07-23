package edu.TecMilenio;

import javax.management.InvalidApplicationException;
import java.io.*;
import java.util.*;

public class Practica_04_AddressBook {
    private static Map<String, String> AgendaTelefonica = null;
    private static BufferedReader datoCapturaB = new BufferedReader(new InputStreamReader(System.in));

    private static String ArchivoProcesar = "src/AgendaTelefonica.txt";

    public static void MuestraMenuAgenda() {
        String sOpcionCol = "";
        boolean bolSigeEvidencia = true;
        try {
            load();
            do{
                System.out.println("\n");
                System.out.println("   ** Manejo de Colecciones **\n");
                System.out.println("        1 - Lista");
                System.out.println("        2 - Crea un contacto");
                System.out.println("        3 - Elimina un contacto");
                System.out.println("        X/x - Regresar Menu Principal.\n");
                System.out.print("Favor de especificar la opción deseada: ");

                sOpcionCol = datoCapturaB.readLine().toString().trim().toUpperCase();

                switch (sOpcionCol) {
                    case "1":
                        list();
                        break;
                    case "2":
                        create();
                        break;
                    case "3":
                        delete();
                        break;
                    case "X":
                        bolSigeEvidencia = false;
                        break;
                    default:
                        System.out.println("");
                        System.out.println("El tipo de dato ingresado no es correcto, ingresar un dato valido.");
                        System.out.println("");
                        MuestraMenuAgenda();
                        break;
                }
                sOpcionCol = "";
            } while (bolSigeEvidencia);
        } catch (Exception ex) {
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        } finally {
        }
    }

    private static void list(){
        try {
            System.out.println("\n\nContactos:");
            for (Map.Entry<String, String> item : AgendaTelefonica.entrySet()) {
                System.out.println("          " + item.getKey() + ", " + item.getValue());
            }
            System.out.print("\n\nPreciona ENTER para continuar. ");
            datoCapturaB.readLine();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
    }
    private static void create(){
        String Telefono = "";
        String Nombre = "";
        try {
            System.out.println("\n                     Alta de un contacto\n");

            Telefono = SolicitaTelefono();
            System.out.print("Favor de proporcionar un nombre:");
            Nombre = datoCapturaB.readLine().toString().trim();

            AgendaTelefonica.put(Telefono, Nombre);

            save();
            System.out.print("\n\nGuardado correctamente. Preciona ENTER para continuar. ");
            datoCapturaB.readLine();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally {
        }
    }
    private static void delete(){
        String sTelefonoEliminar = "";
        String sAccion = "";
        try {
            System.out.println("\n                     Eliminar un contacto. \n");
            sTelefonoEliminar = SolicitaTelefono();

            if (ValidaTelefono(sTelefonoEliminar)) {
                AgendaTelefonica.remove(sTelefonoEliminar);
                System.out.print("\nEliminado correctamente. Preciona ENTER para continuar. ");
                datoCapturaB.readLine();
            }
            else {
                System.out.print("\nEl Teléfono ingresado no existe ingrese una x/X para salir u otro carácter para reintentar: ");
                sAccion = datoCapturaB.readLine().toString().trim().toUpperCase();
                switch (sAccion) {
                    case "X":
                        break;
                    default:
                        delete();
                        break;
                }
            }
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally {
        }
    }

    private static void load(){
        BufferedReader brAgenda = null;
        String sLinea;
        try {
            AgendaTelefonica = new HashMap<>();
            brAgenda = new BufferedReader(new FileReader(ArchivoProcesar));

            while ((sLinea = brAgenda.readLine()) != null) {
                String[] sDato = null;
                if (sLinea != ""){
                    sDato = sLinea.split(",");
                    AgendaTelefonica.put(sDato[0].trim(), sDato[1].trim());
                }
            }
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally {
            try {
                if (brAgenda != null) brAgenda.close();
            }
            catch (IOException ex) { System.out.println(" ¡¡ ERROR !! " + ex.getMessage()); }
        }
    }
    private static void save(){
        BufferedWriter bwAgenda = null;
        String sLinea;
        try {
            bwAgenda = new BufferedWriter(new FileWriter(ArchivoProcesar));

            for (Map.Entry<String, String> item : AgendaTelefonica.entrySet()) {
                bwAgenda.write(item.getKey() + "," + item.getValue() + "\n");
            }
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally {
            try {
                if (bwAgenda != null) bwAgenda.close();
            }
            catch (IOException ex) { System.out.println(" ¡¡ ERROR !! " + ex.getMessage()); }
        }
    }

    private  static String SolicitaTelefono() {
        String Result = "";
        try {
            System.out.print("Favor de proporcionar un teléfono: ");
            Result = datoCapturaB.readLine().toString().trim();

            Long.parseLong(Result);
            if (Result.length() != 10) throw new InvalidApplicationException("Teléfono incorrecto");

        }
        catch (NumberFormatException nfe){
            System.out.println("Teléfono ingresado es erróneo. Tiene que ser puros número y de una longitud 10 caracteres.");
            Result = SolicitaTelefono();
        }
        catch (InvalidApplicationException ex){
            System.out.println("Teléfono ingresado es erróneo. Tiene que ser puros número y de una longitud 10 caracteres.");
            Result = SolicitaTelefono();
        }
        catch (Exception ex){
            System.out.println(" ¡¡ ERROR !! " + ex.getMessage());
        }
        finally { }
        return Result;
    }
    private static Boolean ValidaTelefono(String sTelefono){
        Boolean Result = false;
        for (Map.Entry<String, String> item : AgendaTelefonica.entrySet()) {
            if (item.getKey().equals(sTelefono)) {
                Result = true;
                break;
            }
        }
        return Result;
    }
}
